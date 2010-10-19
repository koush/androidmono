namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PopupWindow : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PopupWindow()
		{
			InitJNI();
		}
		protected PopupWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.PopupWindow.OnDismissListener_))]
		public interface OnDismissListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDismiss();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.PopupWindow.OnDismissListener))]
		public sealed partial class OnDismissListener_ : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDismissListener_()
			{
				InitJNI();
			}
			internal OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDismiss12170;
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_._onDismiss12170);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_.staticClass, global::android.widget.PopupWindow.OnDismissListener_._onDismiss12170);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow$OnDismissListener"));
				global::android.widget.PopupWindow.OnDismissListener_._onDismiss12170 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _update12171;
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update12172;
		public virtual void update() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12172);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12172);
		}
		internal static global::MonoJavaBridge.MethodId _update12173;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update12174;
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update12175;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update12176;
		public virtual void update(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getWidth12177;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getWidth12177);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getWidth12177);
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
		internal static global::MonoJavaBridge.MethodId _getHeight12178;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getHeight12178);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getHeight12178);
		}
		internal static global::MonoJavaBridge.MethodId _setContentView12179;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setContentView12179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setContentView12179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode12180;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setSoftInputMode12180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setSoftInputMode12180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable12181;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setBackgroundDrawable12181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setBackgroundDrawable12181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable12182;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setFocusable12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setFocusable12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable12183;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isFocusable12183);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isFocusable12183);
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground12184;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getBackground12184)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getBackground12184)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing12185;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isShowing12185);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isShowing12185);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss12186;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._dismiss12186);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._dismiss12186);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener12187;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOnDismissListener12187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOnDismissListener12187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight12188;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setHeight12188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setHeight12188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth12189;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWidth12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWidth12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAnimationStyle12190;
		public virtual int getAnimationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getAnimationStyle12190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getAnimationStyle12190);
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreCheekPress12191;
		public virtual void setIgnoreCheekPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setIgnoreCheekPress12191);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setIgnoreCheekPress12191);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationStyle12192;
		public virtual void setAnimationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setAnimationStyle12192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setAnimationStyle12192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentView12193;
		public virtual global::android.view.View getContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getContentView12193)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getContentView12193)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setTouchInterceptor12194;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchInterceptor12194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchInterceptor12194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInputMethodMode12195;
		public virtual int getInputMethodMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getInputMethodMode12195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getInputMethodMode12195);
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethodMode12196;
		public virtual void setInputMethodMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setInputMethodMode12196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setInputMethodMode12196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoftInputMode12197;
		public virtual int getSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getSoftInputMode12197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getSoftInputMode12197);
		}
		internal static global::MonoJavaBridge.MethodId _isTouchable12198;
		public virtual bool isTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isTouchable12198);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isTouchable12198);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchable12199;
		public virtual void setTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchable12199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchable12199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOutsideTouchable12200;
		public virtual bool isOutsideTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isOutsideTouchable12200);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isOutsideTouchable12200);
		}
		internal static global::MonoJavaBridge.MethodId _setOutsideTouchable12201;
		public virtual void setOutsideTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOutsideTouchable12201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOutsideTouchable12201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClippingEnabled12202;
		public virtual bool isClippingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isClippingEnabled12202);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isClippingEnabled12202);
		}
		internal static global::MonoJavaBridge.MethodId _setClippingEnabled12203;
		public virtual void setClippingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setClippingEnabled12203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setClippingEnabled12203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowLayoutMode12204;
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWindowLayoutMode12204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWindowLayoutMode12204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showAtLocation12205;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAtLocation12205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAtLocation12205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown12206;
		public virtual void showAsDropDown(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown12206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown12206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown12207;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown12207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown12207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isAboveAnchor12208;
		public virtual bool isAboveAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isAboveAnchor12208);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isAboveAnchor12208);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight12209;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight12209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight12209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight12210;
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight12210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight12210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12211;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12212;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12213;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12214;
		public PopupWindow()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12214);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12215;
		public PopupWindow(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12216;
		public PopupWindow(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12217;
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow12218;
		public PopupWindow(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow12218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.PopupWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow"));
			global::android.widget.PopupWindow._update12171 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V");
			global::android.widget.PopupWindow._update12172 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "()V");
			global::android.widget.PopupWindow._update12173 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V");
			global::android.widget.PopupWindow._update12174 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._update12175 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V");
			global::android.widget.PopupWindow._update12176 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(II)V");
			global::android.widget.PopupWindow._getWidth12177 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getWidth", "()I");
			global::android.widget.PopupWindow._getHeight12178 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getHeight", "()I");
			global::android.widget.PopupWindow._setContentView12179 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._setSoftInputMode12180 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V");
			global::android.widget.PopupWindow._setBackgroundDrawable12181 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.PopupWindow._setFocusable12182 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V");
			global::android.widget.PopupWindow._isFocusable12183 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z");
			global::android.widget.PopupWindow._getBackground12184 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.PopupWindow._isShowing12185 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z");
			global::android.widget.PopupWindow._dismiss12186 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "dismiss", "()V");
			global::android.widget.PopupWindow._setOnDismissListener12187 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			global::android.widget.PopupWindow._setHeight12188 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V");
			global::android.widget.PopupWindow._setWidth12189 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V");
			global::android.widget.PopupWindow._getAnimationStyle12190 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I");
			global::android.widget.PopupWindow._setIgnoreCheekPress12191 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V");
			global::android.widget.PopupWindow._setAnimationStyle12192 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V");
			global::android.widget.PopupWindow._getContentView12193 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;");
			global::android.widget.PopupWindow._setTouchInterceptor12194 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V");
			global::android.widget.PopupWindow._getInputMethodMode12195 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I");
			global::android.widget.PopupWindow._setInputMethodMode12196 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V");
			global::android.widget.PopupWindow._getSoftInputMode12197 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I");
			global::android.widget.PopupWindow._isTouchable12198 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z");
			global::android.widget.PopupWindow._setTouchable12199 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V");
			global::android.widget.PopupWindow._isOutsideTouchable12200 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z");
			global::android.widget.PopupWindow._setOutsideTouchable12201 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V");
			global::android.widget.PopupWindow._isClippingEnabled12202 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z");
			global::android.widget.PopupWindow._setClippingEnabled12203 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V");
			global::android.widget.PopupWindow._setWindowLayoutMode12204 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V");
			global::android.widget.PopupWindow._showAtLocation12205 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V");
			global::android.widget.PopupWindow._showAsDropDown12206 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._showAsDropDown12207 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._isAboveAnchor12208 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z");
			global::android.widget.PopupWindow._getMaxAvailableHeight12209 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I");
			global::android.widget.PopupWindow._getMaxAvailableHeight12210 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I");
			global::android.widget.PopupWindow._PopupWindow12211 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::android.widget.PopupWindow._PopupWindow12212 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.PopupWindow._PopupWindow12213 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.PopupWindow._PopupWindow12214 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::android.widget.PopupWindow._PopupWindow12215 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._PopupWindow12216 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::android.widget.PopupWindow._PopupWindow12217 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._PopupWindow12218 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
