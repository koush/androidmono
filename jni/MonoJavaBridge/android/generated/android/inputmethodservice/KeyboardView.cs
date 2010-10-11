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
		public interface OnKeyboardActionListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onKey4611;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey4611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey4611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPress4612;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress4612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress4612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onRelease4613;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease4613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease4613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onText4614;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText4614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText4614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _swipeLeft4615;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft4615);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft4615);
			}
			internal static global::MonoJavaBridge.MethodId _swipeRight4616;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight4616);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight4616);
			}
			internal static global::MonoJavaBridge.MethodId _swipeDown4617;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown4617);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown4617);
			}
			internal static global::MonoJavaBridge.MethodId _swipeUp4618;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp4618);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp4618);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView$OnKeyboardActionListener"));
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onKey4611 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onKey", "(I[I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onPress4612 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onPress", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onRelease4613 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onRelease", "(I)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._onText4614 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onText", "(Ljava/lang/CharSequence;)V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeLeft4615 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeLeft", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeRight4616 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeRight", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeDown4617 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeDown", "()V");
				global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._swipeUp4618 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeUp", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _closing4619;
		public virtual void closing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._closing4619);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._closing4619);
		}
		internal static global::MonoJavaBridge.MethodId _onClick4620;
		public virtual void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onClick4620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onClick4620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent4621;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onTouchEvent4621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onTouchEvent4621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow4622;
		public virtual new void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4622);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4622);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged4623;
		public virtual new void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onSizeChanged4623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onSizeChanged4623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw4624;
		public virtual new void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onDraw4624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDraw4624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure4625;
		public virtual new void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onMeasure4625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onMeasure4625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShifted4626;
		public virtual bool setShifted(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setShifted4626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setShifted4626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted4627;
		public virtual bool isShifted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isShifted4627);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isShifted4627);
		}
		internal static global::MonoJavaBridge.MethodId _swipeLeft4628;
		protected virtual void swipeLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeLeft4628);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeLeft4628);
		}
		internal static global::MonoJavaBridge.MethodId _swipeRight4629;
		protected virtual void swipeRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeRight4629);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeRight4629);
		}
		internal static global::MonoJavaBridge.MethodId _swipeDown4630;
		protected virtual void swipeDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeDown4630);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeDown4630);
		}
		internal static global::MonoJavaBridge.MethodId _swipeUp4631;
		protected virtual void swipeUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._swipeUp4631);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeUp4631);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyboardActionListener4632;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnKeyboardActionListener4633;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4633)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4633)) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyboard4634;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setKeyboard4634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setKeyboard4634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyboard4635;
		public virtual global::android.inputmethodservice.Keyboard getKeyboard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._getKeyboard4635)) as android.inputmethodservice.Keyboard;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getKeyboard4635)) as android.inputmethodservice.Keyboard;
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewEnabled4636;
		public virtual void setPreviewEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPreviewEnabled4637;
		public virtual bool isPreviewEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4637);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4637);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalCorrection4638;
		public virtual void setVerticalCorrection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupParent4639;
		public virtual void setPopupParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupParent4639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupParent4639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPopupOffset4640;
		public virtual void setPopupOffset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setPopupOffset4640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupOffset4640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setProximityCorrectionEnabled4641;
		public virtual void setProximityCorrectionEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProximityCorrectionEnabled4642;
		public virtual bool isProximityCorrectionEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4642);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4642);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateAllKeys4643;
		public virtual void invalidateAllKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4643);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4643);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateKey4644;
		public virtual void invalidateKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._invalidateKey4644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateKey4644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress4645;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._onLongPress4645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onLongPress4645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleBack4646;
		public virtual bool handleBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView._handleBack4646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._handleBack4646);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView4647;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyboardView4648;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.KeyboardView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/KeyboardView"));
			global::android.inputmethodservice.KeyboardView._closing4619 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V");
			global::android.inputmethodservice.KeyboardView._onClick4620 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._onTouchEvent4621 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4622 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V");
			global::android.inputmethodservice.KeyboardView._onSizeChanged4623 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.inputmethodservice.KeyboardView._onDraw4624 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.inputmethodservice.KeyboardView._onMeasure4625 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V");
			global::android.inputmethodservice.KeyboardView._setShifted4626 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.KeyboardView._isShifted4627 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.KeyboardView._swipeLeft4628 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V");
			global::android.inputmethodservice.KeyboardView._swipeRight4629 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V");
			global::android.inputmethodservice.KeyboardView._swipeDown4630 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V");
			global::android.inputmethodservice.KeyboardView._swipeUp4631 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V");
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4632 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V");
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4633 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;");
			global::android.inputmethodservice.KeyboardView._setKeyboard4634 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V");
			global::android.inputmethodservice.KeyboardView._getKeyboard4635 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;");
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled4636 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled4637 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection4638 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V");
			global::android.inputmethodservice.KeyboardView._setPopupParent4639 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._setPopupOffset4640 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V");
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4641 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4642 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys4643 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V");
			global::android.inputmethodservice.KeyboardView._invalidateKey4644 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V");
			global::android.inputmethodservice.KeyboardView._onLongPress4645 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z");
			global::android.inputmethodservice.KeyboardView._handleBack4646 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z");
			global::android.inputmethodservice.KeyboardView._KeyboardView4647 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.inputmethodservice.KeyboardView._KeyboardView4648 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
