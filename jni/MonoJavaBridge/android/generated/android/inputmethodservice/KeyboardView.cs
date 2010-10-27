namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyboardView : android.view.View, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyboardView()
		{
			InitJNI();
		}
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
			static OnKeyboardActionListener_()
			{
				InitJNI();
			}
			internal OnKeyboardActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey6757;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPress6758;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onRelease6759;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onText6760;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _swipeLeft6761;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6761);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6761);
			}
			internal static global::MonoJavaBridge.MethodId _swipeRight6762;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6762);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6762);
			}
			internal static global::MonoJavaBridge.MethodId _swipeDown6763;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6763);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6763);
			}
			internal static global::MonoJavaBridge.MethodId _swipeUp6764;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6764);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6764);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView$OnKeyboardActionListener"));
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6757 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onKey", "(I[I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6758 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onPress", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6759 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onRelease", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6760 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onText", "(Ljava/lang/CharSequence;)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6761 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeLeft", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6762 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeRight", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6763 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeDown", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6764 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeUp", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _closing6765;
		public virtual void closing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._closing6765);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._closing6765);
		}
		internal static global::MonoJavaBridge.MethodId _onClick6766;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onClick6766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onClick6766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent6767;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onTouchEvent6767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onTouchEvent6767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow6768;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6768);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6768);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged6769;
		public virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onSizeChanged6769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onSizeChanged6769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw6770;
		public virtual void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDraw6770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDraw6770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure6771;
		public virtual void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onMeasure6771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onMeasure6771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setShifted6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setShifted6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted6773;
		public virtual bool isShifted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isShifted6773);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isShifted6773);
		}
		internal static global::MonoJavaBridge.MethodId _swipeLeft6774;
		protected virtual void swipeLeft()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeLeft6774);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeLeft6774);
		}
		internal static global::MonoJavaBridge.MethodId _swipeRight6775;
		protected virtual void swipeRight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeRight6775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeRight6775);
		}
		internal static global::MonoJavaBridge.MethodId _swipeDown6776;
		protected virtual void swipeDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeDown6776);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeDown6776);
		}
		internal static global::MonoJavaBridge.MethodId _swipeUp6777;
		protected virtual void swipeUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeUp6777);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeUp6777);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyboardActionListener6778;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnKeyboardActionListener6779;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6779)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6779)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyboard6780;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setKeyboard6780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setKeyboard6780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getKeyboard6781)) as android.inputmethodservice.Keyboard;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getKeyboard6781)) as android.inputmethodservice.Keyboard;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPreviewEnabled6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPreviewEnabled6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPreviewEnabled6783;
		public virtual bool isPreviewEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isPreviewEnabled6783);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isPreviewEnabled6783);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setVerticalCorrection6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setVerticalCorrection6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupParent6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupParent6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupOffset6786;
		public virtual void setPopupOffset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupOffset6786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupOffset6786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProximityCorrectionEnabled6788;
		public virtual bool isProximityCorrectionEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6788);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6788);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateAllKeys6789;
		public virtual void invalidateAllKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateAllKeys6789);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateAllKeys6789);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateKey6790;
		public virtual void invalidateKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateKey6790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateKey6790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress6791;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onLongPress6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onLongPress6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleBack6792;
		public virtual bool handleBack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._handleBack6792);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._handleBack6792);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6793;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6794;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.KeyboardView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView"));
			global::android.inputmethodservice.KeyboardView._closing6765 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V");
			global::android.inputmethodservice.KeyboardView._onClick6766 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._onTouchEvent6767 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6768 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V");
			global::android.inputmethodservice.KeyboardView._onSizeChanged6769 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.inputmethodservice.KeyboardView._onDraw6770 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.inputmethodservice.KeyboardView._onMeasure6771 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V");
			global::android.inputmethodservice.KeyboardView._setShifted6772 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.KeyboardView._isShifted6773 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.KeyboardView._swipeLeft6774 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V");
			global::android.inputmethodservice.KeyboardView._swipeRight6775 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V");
			global::android.inputmethodservice.KeyboardView._swipeDown6776 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V");
			global::android.inputmethodservice.KeyboardView._swipeUp6777 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V");
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6778 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V");
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6779 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;");
			global::android.inputmethodservice.KeyboardView._setKeyboard6780 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V");
			global::android.inputmethodservice.KeyboardView._getKeyboard6781 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;");
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled6782 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled6783 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection6784 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V");
			global::android.inputmethodservice.KeyboardView._setPopupParent6785 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._setPopupOffset6786 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V");
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6787 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6788 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys6789 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V");
			global::android.inputmethodservice.KeyboardView._invalidateKey6790 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V");
			global::android.inputmethodservice.KeyboardView._onLongPress6791 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z");
			global::android.inputmethodservice.KeyboardView._handleBack6792 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z");
			global::android.inputmethodservice.KeyboardView._KeyboardView6793 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.inputmethodservice.KeyboardView._KeyboardView6794 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
