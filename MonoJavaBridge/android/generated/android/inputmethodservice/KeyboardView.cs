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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onKey", "(I[I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onPress", "(I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onRelease", "(I)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "onText", "(Ljava/lang/CharSequence;)V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeLeft", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeRight", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeDown", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m6);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_.staticClass, "swipeUp", "()V", ref global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener_._m7);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void closing()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V", ref global::android.inputmethodservice.KeyboardView._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.inputmethodservice.KeyboardView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.inputmethodservice.KeyboardView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V", ref global::android.inputmethodservice.KeyboardView._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.inputmethodservice.KeyboardView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.inputmethodservice.KeyboardView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V", ref global::android.inputmethodservice.KeyboardView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Shifted
		{
			set
			{
				setShifted(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool setShifted(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z", ref global::android.inputmethodservice.KeyboardView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isShifted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z", ref global::android.inputmethodservice.KeyboardView._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void swipeLeft()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V", ref global::android.inputmethodservice.KeyboardView._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void swipeRight()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V", ref global::android.inputmethodservice.KeyboardView._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void swipeDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V", ref global::android.inputmethodservice.KeyboardView._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void swipeUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V", ref global::android.inputmethodservice.KeyboardView._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", ref global::android.inputmethodservice.KeyboardView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(this, global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", ref global::android.inputmethodservice.KeyboardView._m14) as android.inputmethodservice.KeyboardView.OnKeyboardActionListener;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", ref global::android.inputmethodservice.KeyboardView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.inputmethodservice.Keyboard getKeyboard()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;", ref global::android.inputmethodservice.KeyboardView._m16) as android.inputmethodservice.Keyboard;
		}
		public new bool PreviewEnabled
		{
			set
			{
				setPreviewEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setPreviewEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V", ref global::android.inputmethodservice.KeyboardView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isPreviewEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z", ref global::android.inputmethodservice.KeyboardView._m18);
		}
		public new int VerticalCorrection
		{
			set
			{
				setVerticalCorrection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setVerticalCorrection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V", ref global::android.inputmethodservice.KeyboardView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View PopupParent
		{
			set
			{
				setPopupParent(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setPopupParent(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V", ref global::android.inputmethodservice.KeyboardView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setPopupOffset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V", ref global::android.inputmethodservice.KeyboardView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool ProximityCorrectionEnabled
		{
			set
			{
				setProximityCorrectionEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setProximityCorrectionEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V", ref global::android.inputmethodservice.KeyboardView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isProximityCorrectionEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z", ref global::android.inputmethodservice.KeyboardView._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void invalidateAllKeys()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V", ref global::android.inputmethodservice.KeyboardView._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void invalidateKey(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V", ref global::android.inputmethodservice.KeyboardView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z", ref global::android.inputmethodservice.KeyboardView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool handleBack()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z", ref global::android.inputmethodservice.KeyboardView._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.KeyboardView._m28.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.KeyboardView._m28 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.KeyboardView._m29.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.KeyboardView._m29 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
