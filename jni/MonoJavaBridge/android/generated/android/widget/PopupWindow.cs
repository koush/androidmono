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
			internal static global::MonoJavaBridge.MethodId _onDismiss17335;
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_._onDismiss17335);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_.staticClass, global::android.widget.PopupWindow.OnDismissListener_._onDismiss17335);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow$OnDismissListener"));
				global::android.widget.PopupWindow.OnDismissListener_._onDismiss17335 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _update17336;
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update17337;
		public virtual void update() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17337);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17337);
		}
		internal static global::MonoJavaBridge.MethodId _update17338;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update17339;
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update17340;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update17341;
		public virtual void update(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getWidth17342;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getWidth17342);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getWidth17342);
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
		internal static global::MonoJavaBridge.MethodId _getHeight17343;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getHeight17343);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getHeight17343);
		}
		internal static global::MonoJavaBridge.MethodId _setContentView17344;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setContentView17344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setContentView17344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode17345;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setSoftInputMode17345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setSoftInputMode17345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable17346;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setBackgroundDrawable17346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setBackgroundDrawable17346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable17347;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setFocusable17347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setFocusable17347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable17348;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isFocusable17348);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isFocusable17348);
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground17349;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getBackground17349)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getBackground17349)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing17350;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isShowing17350);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isShowing17350);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss17351;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._dismiss17351);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._dismiss17351);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener17352;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOnDismissListener17352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOnDismissListener17352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight17353;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setHeight17353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setHeight17353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth17354;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWidth17354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWidth17354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAnimationStyle17355;
		public virtual int getAnimationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getAnimationStyle17355);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getAnimationStyle17355);
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreCheekPress17356;
		public virtual void setIgnoreCheekPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setIgnoreCheekPress17356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setIgnoreCheekPress17356);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationStyle17357;
		public virtual void setAnimationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setAnimationStyle17357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setAnimationStyle17357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentView17358;
		public virtual global::android.view.View getContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getContentView17358)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getContentView17358)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setTouchInterceptor17359;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchInterceptor17359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchInterceptor17359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInputMethodMode17360;
		public virtual int getInputMethodMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getInputMethodMode17360);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getInputMethodMode17360);
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethodMode17361;
		public virtual void setInputMethodMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setInputMethodMode17361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setInputMethodMode17361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoftInputMode17362;
		public virtual int getSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getSoftInputMode17362);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getSoftInputMode17362);
		}
		internal static global::MonoJavaBridge.MethodId _isTouchable17363;
		public virtual bool isTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isTouchable17363);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isTouchable17363);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchable17364;
		public virtual void setTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchable17364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchable17364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOutsideTouchable17365;
		public virtual bool isOutsideTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isOutsideTouchable17365);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isOutsideTouchable17365);
		}
		internal static global::MonoJavaBridge.MethodId _setOutsideTouchable17366;
		public virtual void setOutsideTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOutsideTouchable17366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOutsideTouchable17366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClippingEnabled17367;
		public virtual bool isClippingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isClippingEnabled17367);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isClippingEnabled17367);
		}
		internal static global::MonoJavaBridge.MethodId _setClippingEnabled17368;
		public virtual void setClippingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setClippingEnabled17368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setClippingEnabled17368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowLayoutMode17369;
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWindowLayoutMode17369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWindowLayoutMode17369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showAtLocation17370;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAtLocation17370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAtLocation17370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown17371;
		public virtual void showAsDropDown(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown17371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown17371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown17372;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown17372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown17372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isAboveAnchor17373;
		public virtual bool isAboveAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isAboveAnchor17373);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isAboveAnchor17373);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight17374;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight17375;
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight17375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight17375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17376;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17377;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17378;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17379;
		public PopupWindow()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17379);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17380;
		public PopupWindow(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17381;
		public PopupWindow(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17382;
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17383;
		public PopupWindow(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.PopupWindow._update17336 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V");
			global::android.widget.PopupWindow._update17337 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "()V");
			global::android.widget.PopupWindow._update17338 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V");
			global::android.widget.PopupWindow._update17339 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._update17340 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V");
			global::android.widget.PopupWindow._update17341 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(II)V");
			global::android.widget.PopupWindow._getWidth17342 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getWidth", "()I");
			global::android.widget.PopupWindow._getHeight17343 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getHeight", "()I");
			global::android.widget.PopupWindow._setContentView17344 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._setSoftInputMode17345 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V");
			global::android.widget.PopupWindow._setBackgroundDrawable17346 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.PopupWindow._setFocusable17347 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V");
			global::android.widget.PopupWindow._isFocusable17348 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z");
			global::android.widget.PopupWindow._getBackground17349 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.PopupWindow._isShowing17350 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z");
			global::android.widget.PopupWindow._dismiss17351 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "dismiss", "()V");
			global::android.widget.PopupWindow._setOnDismissListener17352 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			global::android.widget.PopupWindow._setHeight17353 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V");
			global::android.widget.PopupWindow._setWidth17354 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V");
			global::android.widget.PopupWindow._getAnimationStyle17355 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I");
			global::android.widget.PopupWindow._setIgnoreCheekPress17356 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V");
			global::android.widget.PopupWindow._setAnimationStyle17357 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V");
			global::android.widget.PopupWindow._getContentView17358 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;");
			global::android.widget.PopupWindow._setTouchInterceptor17359 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V");
			global::android.widget.PopupWindow._getInputMethodMode17360 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I");
			global::android.widget.PopupWindow._setInputMethodMode17361 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V");
			global::android.widget.PopupWindow._getSoftInputMode17362 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I");
			global::android.widget.PopupWindow._isTouchable17363 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z");
			global::android.widget.PopupWindow._setTouchable17364 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V");
			global::android.widget.PopupWindow._isOutsideTouchable17365 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z");
			global::android.widget.PopupWindow._setOutsideTouchable17366 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V");
			global::android.widget.PopupWindow._isClippingEnabled17367 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z");
			global::android.widget.PopupWindow._setClippingEnabled17368 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V");
			global::android.widget.PopupWindow._setWindowLayoutMode17369 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V");
			global::android.widget.PopupWindow._showAtLocation17370 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V");
			global::android.widget.PopupWindow._showAsDropDown17371 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._showAsDropDown17372 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._isAboveAnchor17373 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z");
			global::android.widget.PopupWindow._getMaxAvailableHeight17374 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I");
			global::android.widget.PopupWindow._getMaxAvailableHeight17375 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I");
			global::android.widget.PopupWindow._PopupWindow17376 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::android.widget.PopupWindow._PopupWindow17377 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.PopupWindow._PopupWindow17378 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.PopupWindow._PopupWindow17379 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::android.widget.PopupWindow._PopupWindow17380 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._PopupWindow17381 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::android.widget.PopupWindow._PopupWindow17382 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._PopupWindow17383 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
