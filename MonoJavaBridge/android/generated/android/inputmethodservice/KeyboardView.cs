namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyboardView : android.view.View, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyboardView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_))]
		public partial interface OnKeyboardActionListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onKey(int arg0, int[] arg1);
			void onPress(int arg0);
			void onRelease(int arg0);
			void onText(java.lang.CharSequence arg0);
			void swipeLeft();
			void swipeRight();
			void swipeDown();
			void swipeUp();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener))]
		internal sealed partial class OnKeyboardActionListener_ : java.lang.Object, OnKeyboardActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnKeyboardActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey6757;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onKey", "(I[I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPress6758;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onPress", "(I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onRelease6759;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onRelease", "(I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onText6760;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onText", "(Ljava/lang/CharSequence;)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _swipeLeft6761;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeLeft", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6761);
			}
			internal static global::MonoJavaBridge.MethodId _swipeRight6762;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeRight", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6762);
			}
			internal static global::MonoJavaBridge.MethodId _swipeDown6763;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeDown", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6763);
			}
			internal static global::MonoJavaBridge.MethodId _swipeUp6764;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeUp", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6764);
			}
			static OnKeyboardActionListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView$OnKeyboardActionListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _closing6765;
		public virtual void closing()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V", ref global::android.inputmethodservice.KeyboardView._closing6765);
		}
		internal static global::MonoJavaBridge.MethodId _onClick6766;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.inputmethodservice.KeyboardView._onClick6766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent6767;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.inputmethodservice.KeyboardView._onTouchEvent6767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow6768;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V", ref global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6768);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged6769;
		public virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.inputmethodservice.KeyboardView._onSizeChanged6769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw6770;
		public virtual void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.inputmethodservice.KeyboardView._onDraw6770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure6771;
		public virtual void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V", ref global::android.inputmethodservice.KeyboardView._onMeasure6771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Shifted
		{
			set
			{
				setShifted(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setShifted6772;
		public virtual bool setShifted(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z", ref global::android.inputmethodservice.KeyboardView._setShifted6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted6773;
		public virtual bool isShifted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z", ref global::android.inputmethodservice.KeyboardView._isShifted6773);
		}
		internal static global::MonoJavaBridge.MethodId _swipeLeft6774;
		protected virtual void swipeLeft()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V", ref global::android.inputmethodservice.KeyboardView._swipeLeft6774);
		}
		internal static global::MonoJavaBridge.MethodId _swipeRight6775;
		protected virtual void swipeRight()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V", ref global::android.inputmethodservice.KeyboardView._swipeRight6775);
		}
		internal static global::MonoJavaBridge.MethodId _swipeDown6776;
		protected virtual void swipeDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V", ref global::android.inputmethodservice.KeyboardView._swipeDown6776);
		}
		internal static global::MonoJavaBridge.MethodId _swipeUp6777;
		protected virtual void swipeUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V", ref global::android.inputmethodservice.KeyboardView._swipeUp6777);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyboardActionListener6778;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", ref global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnKeyboardActionListener6779;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(this, global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", ref global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6779) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyboard6780;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", ref global::android.inputmethodservice.KeyboardView._setKeyboard6780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.inputmethodservice.Keyboard Keyboard
		{
			get
			{
				return getKeyboard();
			}
			set
			{
				setKeyboard(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyboard6781;
		public virtual global::android.inputmethodservice.Keyboard getKeyboard()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;", ref global::android.inputmethodservice.KeyboardView._getKeyboard6781) as android.inputmethodservice.Keyboard;
		}
		public new bool PreviewEnabled
		{
			set
			{
				setPreviewEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewEnabled6782;
		public virtual void setPreviewEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V", ref global::android.inputmethodservice.KeyboardView._setPreviewEnabled6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPreviewEnabled6783;
		public virtual bool isPreviewEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z", ref global::android.inputmethodservice.KeyboardView._isPreviewEnabled6783);
		}
		public new int VerticalCorrection
		{
			set
			{
				setVerticalCorrection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalCorrection6784;
		public virtual void setVerticalCorrection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V", ref global::android.inputmethodservice.KeyboardView._setVerticalCorrection6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View PopupParent
		{
			set
			{
				setPopupParent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPopupParent6785;
		public virtual void setPopupParent(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V", ref global::android.inputmethodservice.KeyboardView._setPopupParent6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupOffset6786;
		public virtual void setPopupOffset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V", ref global::android.inputmethodservice.KeyboardView._setPopupOffset6786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool ProximityCorrectionEnabled
		{
			set
			{
				setProximityCorrectionEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProximityCorrectionEnabled6787;
		public virtual void setProximityCorrectionEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V", ref global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProximityCorrectionEnabled6788;
		public virtual bool isProximityCorrectionEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z", ref global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6788);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateAllKeys6789;
		public virtual void invalidateAllKeys()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V", ref global::android.inputmethodservice.KeyboardView._invalidateAllKeys6789);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateKey6790;
		public virtual void invalidateKey(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V", ref global::android.inputmethodservice.KeyboardView._invalidateKey6790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress6791;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z", ref global::android.inputmethodservice.KeyboardView._onLongPress6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleBack6792;
		public virtual bool handleBack()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z", ref global::android.inputmethodservice.KeyboardView._handleBack6792);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6793;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.KeyboardView._KeyboardView6793.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.KeyboardView._KeyboardView6793 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6794;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.KeyboardView._KeyboardView6794.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.KeyboardView._KeyboardView6794 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static KeyboardView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.KeyboardView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
