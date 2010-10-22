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
		public sealed partial class OnKeyboardActionListener_ : java.lang.Object, OnKeyboardActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnKeyboardActionListener_()
			{
				InitJNI();
			}
			internal OnKeyboardActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey6732;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPress6733;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onRelease6734;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onText6735;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _swipeLeft6736;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6736);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6736);
			}
			internal static global::MonoJavaBridge.MethodId _swipeRight6737;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6737);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6737);
			}
			internal static global::MonoJavaBridge.MethodId _swipeDown6738;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6738);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6738);
			}
			internal static global::MonoJavaBridge.MethodId _swipeUp6739;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6739);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6739);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView$OnKeyboardActionListener"));
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey6732 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onKey", "(I[I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress6733 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onPress", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease6734 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onRelease", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText6735 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onText", "(Ljava/lang/CharSequence;)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft6736 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeLeft", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight6737 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeRight", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown6738 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeDown", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp6739 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeUp", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _closing6740;
		public virtual void closing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._closing6740);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._closing6740);
		}
		internal static global::MonoJavaBridge.MethodId _onClick6741;
		public virtual void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onClick6741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onClick6741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent6742;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onTouchEvent6742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onTouchEvent6742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow6743;
		public virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6743);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6743);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged6744;
		public virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onSizeChanged6744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onSizeChanged6744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw6745;
		public virtual void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDraw6745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDraw6745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure6746;
		public virtual void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onMeasure6746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onMeasure6746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShifted6747;
		public virtual bool setShifted(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setShifted6747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setShifted6747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted6748;
		public virtual bool isShifted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isShifted6748);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isShifted6748);
		}
		internal static global::MonoJavaBridge.MethodId _swipeLeft6749;
		protected virtual void swipeLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeLeft6749);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeLeft6749);
		}
		internal static global::MonoJavaBridge.MethodId _swipeRight6750;
		protected virtual void swipeRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeRight6750);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeRight6750);
		}
		internal static global::MonoJavaBridge.MethodId _swipeDown6751;
		protected virtual void swipeDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeDown6751);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeDown6751);
		}
		internal static global::MonoJavaBridge.MethodId _swipeUp6752;
		protected virtual void swipeUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeUp6752);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeUp6752);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyboardActionListener6753;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnKeyboardActionListener6754;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6754)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6754)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyboard6755;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setKeyboard6755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setKeyboard6755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeyboard6756;
		public virtual global::android.inputmethodservice.Keyboard getKeyboard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getKeyboard6756)) as android.inputmethodservice.Keyboard;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getKeyboard6756)) as android.inputmethodservice.Keyboard;
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewEnabled6757;
		public virtual void setPreviewEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPreviewEnabled6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPreviewEnabled6757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPreviewEnabled6758;
		public virtual bool isPreviewEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isPreviewEnabled6758);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isPreviewEnabled6758);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalCorrection6759;
		public virtual void setVerticalCorrection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setVerticalCorrection6759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setVerticalCorrection6759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupParent6760;
		public virtual void setPopupParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupParent6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupParent6760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupOffset6761;
		public virtual void setPopupOffset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupOffset6761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupOffset6761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setProximityCorrectionEnabled6762;
		public virtual void setProximityCorrectionEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProximityCorrectionEnabled6763;
		public virtual bool isProximityCorrectionEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6763);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateAllKeys6764;
		public virtual void invalidateAllKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateAllKeys6764);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateAllKeys6764);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateKey6765;
		public virtual void invalidateKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateKey6765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateKey6765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress6766;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onLongPress6766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onLongPress6766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleBack6767;
		public virtual bool handleBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._handleBack6767);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._handleBack6767);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6768;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView6769;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView6769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.KeyboardView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView"));
			global::android.inputmethodservice.KeyboardView._closing6740 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V");
			global::android.inputmethodservice.KeyboardView._onClick6741 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._onTouchEvent6742 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow6743 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V");
			global::android.inputmethodservice.KeyboardView._onSizeChanged6744 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.inputmethodservice.KeyboardView._onDraw6745 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.inputmethodservice.KeyboardView._onMeasure6746 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V");
			global::android.inputmethodservice.KeyboardView._setShifted6747 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.KeyboardView._isShifted6748 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.KeyboardView._swipeLeft6749 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V");
			global::android.inputmethodservice.KeyboardView._swipeRight6750 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V");
			global::android.inputmethodservice.KeyboardView._swipeDown6751 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V");
			global::android.inputmethodservice.KeyboardView._swipeUp6752 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V");
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener6753 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V");
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener6754 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;");
			global::android.inputmethodservice.KeyboardView._setKeyboard6755 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V");
			global::android.inputmethodservice.KeyboardView._getKeyboard6756 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;");
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled6757 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled6758 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection6759 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V");
			global::android.inputmethodservice.KeyboardView._setPopupParent6760 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._setPopupOffset6761 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V");
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled6762 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled6763 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys6764 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V");
			global::android.inputmethodservice.KeyboardView._invalidateKey6765 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V");
			global::android.inputmethodservice.KeyboardView._onLongPress6766 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z");
			global::android.inputmethodservice.KeyboardView._handleBack6767 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z");
			global::android.inputmethodservice.KeyboardView._KeyboardView6768 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.inputmethodservice.KeyboardView._KeyboardView6769 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
