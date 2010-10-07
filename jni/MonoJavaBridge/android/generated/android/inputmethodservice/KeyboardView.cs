namespace android.inputmethodservice
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class KeyboardView : android.view.View, android.view.View.OnClickListener
	{
		internal new static global::java.lang.Class staticClass;
		static KeyboardView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.KeyboardView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.inputmethodservice.KeyboardView(@__env);
			}
		}
		protected KeyboardView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnKeyboardActionListener 
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

		public partial class OnKeyboardActionListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnKeyboardActionListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnKeyboardActionListener : java.lang.Object, OnKeyboardActionListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnKeyboardActionListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener(@__env);
				}
			}
			internal __OnKeyboardActionListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onKey4389;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPress4390;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onRelease4391;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onText4392;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _swipeLeft4393;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4393);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4393);
			}
			internal static global::net.sf.jni4net.jni.MethodId _swipeRight4394;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4394);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4394);
			}
			internal static global::net.sf.jni4net.jni.MethodId _swipeDown4395;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4395);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4395);
			}
			internal static global::net.sf.jni4net.jni.MethodId _swipeUp4396;
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4396);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4396);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass = @__class;
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4389 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey", "(I[I)V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4390 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress", "(I)V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4391 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease", "(I)V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4392 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText", "(Ljava/lang/CharSequence;)V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4393 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft", "()V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4394 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight", "()V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4395 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown", "()V");
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4396 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _closing4397;
		public virtual void closing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._closing4397);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._closing4397);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick4398;
		public virtual void onClick(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onClick4398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onClick4398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent4399;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._onTouchEvent4399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onTouchEvent4399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow4400;
		public virtual new void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4400);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4400);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged4401;
		public virtual new void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onSizeChanged4401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onSizeChanged4401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw4402;
		public virtual new void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onDraw4402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDraw4402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure4403;
		public virtual new void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onMeasure4403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onMeasure4403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShifted4404;
		public virtual bool setShifted(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._setShifted4404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setShifted4404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShifted4405;
		public virtual bool isShifted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isShifted4405);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isShifted4405);
		}
		internal static global::net.sf.jni4net.jni.MethodId _swipeLeft4406;
		protected virtual void swipeLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeLeft4406);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeLeft4406);
		}
		internal static global::net.sf.jni4net.jni.MethodId _swipeRight4407;
		protected virtual void swipeRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeRight4407);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeRight4407);
		}
		internal static global::net.sf.jni4net.jni.MethodId _swipeDown4408;
		protected virtual void swipeDown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeDown4408);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeDown4408);
		}
		internal static global::net.sf.jni4net.jni.MethodId _swipeUp4409;
		protected virtual void swipeUp() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeUp4409);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeUp4409);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyboardActionListener4410;
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnKeyboardActionListener4411;
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4411));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4411));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyboard4412;
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setKeyboard4412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setKeyboard4412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyboard4413;
		public virtual global::android.inputmethodservice.Keyboard getKeyboard() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView._getKeyboard4413));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getKeyboard4413));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewEnabled4414;
		public virtual void setPreviewEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPreviewEnabled4415;
		public virtual bool isPreviewEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4415);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4415);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalCorrection4416;
		public virtual void setVerticalCorrection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPopupParent4417;
		public virtual void setPopupParent(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPopupParent4417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupParent4417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPopupOffset4418;
		public virtual void setPopupOffset(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPopupOffset4418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupOffset4418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProximityCorrectionEnabled4419;
		public virtual void setProximityCorrectionEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isProximityCorrectionEnabled4420;
		public virtual bool isProximityCorrectionEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4420);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4420);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateAllKeys4421;
		public virtual void invalidateAllKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4421);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4421);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateKey4422;
		public virtual void invalidateKey(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._invalidateKey4422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateKey4422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLongPress4423;
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._onLongPress4423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onLongPress4423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleBack4424;
		public virtual bool handleBack() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._handleBack4424);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._handleBack4424);
		}
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView4425;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4425, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView4426;
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4426, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.inputmethodservice.KeyboardView.staticClass = @__class;
			global::android.inputmethodservice.KeyboardView._closing4397 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V");
			global::android.inputmethodservice.KeyboardView._onClick4398 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._onTouchEvent4399 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4400 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V");
			global::android.inputmethodservice.KeyboardView._onSizeChanged4401 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.inputmethodservice.KeyboardView._onDraw4402 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.inputmethodservice.KeyboardView._onMeasure4403 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V");
			global::android.inputmethodservice.KeyboardView._setShifted4404 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.KeyboardView._isShifted4405 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.KeyboardView._swipeLeft4406 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V");
			global::android.inputmethodservice.KeyboardView._swipeRight4407 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V");
			global::android.inputmethodservice.KeyboardView._swipeDown4408 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V");
			global::android.inputmethodservice.KeyboardView._swipeUp4409 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V");
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4410 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V");
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4411 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;");
			global::android.inputmethodservice.KeyboardView._setKeyboard4412 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V");
			global::android.inputmethodservice.KeyboardView._getKeyboard4413 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;");
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled4414 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled4415 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection4416 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V");
			global::android.inputmethodservice.KeyboardView._setPopupParent4417 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V");
			global::android.inputmethodservice.KeyboardView._setPopupOffset4418 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V");
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4419 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V");
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4420 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z");
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys4421 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V");
			global::android.inputmethodservice.KeyboardView._invalidateKey4422 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V");
			global::android.inputmethodservice.KeyboardView._onLongPress4423 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z");
			global::android.inputmethodservice.KeyboardView._handleBack4424 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z");
			global::android.inputmethodservice.KeyboardView._KeyboardView4425 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.inputmethodservice.KeyboardView._KeyboardView4426 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
