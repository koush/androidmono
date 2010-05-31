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
			internal static global::net.sf.jni4net.jni.MethodId _onKey4157; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey(int arg0, int[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPress4158; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onRelease4159; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onText4160; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _swipeLeft4161; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4161); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4161); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _swipeRight4162; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4162); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4162); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _swipeDown4163; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4163); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4163); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _swipeUp4164; 
			 void android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4164); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4164); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass = @__class; 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onKey4157 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onKey", "(I[I)V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onPress4158 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onPress", "(I)V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onRelease4159 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onRelease", "(I)V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._onText4160 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.onText", "(Ljava/lang/CharSequence;)V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeLeft4161 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeLeft", "()V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeRight4162 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeRight", "()V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeDown4163 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeDown", "()V"); 
				global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener._swipeUp4164 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.__OnKeyboardActionListener.staticClass, "android.inputmethodservice.KeyboardView.OnKeyboardActionListener.swipeUp", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closing4165; 
		public virtual void closing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._closing4165); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._closing4165); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick4166; 
		public virtual void onClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onClick4166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onClick4166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent4167; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._onTouchEvent4167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onTouchEvent4167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow4168; 
		public virtual new void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4168); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4168); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged4169; 
		public virtual new void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onSizeChanged4169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onSizeChanged4169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw4170; 
		public virtual new void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onDraw4170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onDraw4170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure4171; 
		public virtual new void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._onMeasure4171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onMeasure4171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShifted4172; 
		public virtual bool setShifted(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._setShifted4172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setShifted4172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShifted4173; 
		public virtual bool isShifted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isShifted4173); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isShifted4173); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeLeft4174; 
		protected virtual void swipeLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeLeft4174); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeLeft4174); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeRight4175; 
		protected virtual void swipeRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeRight4175); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeRight4175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeDown4176; 
		protected virtual void swipeDown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeDown4176); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeDown4176); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeUp4177; 
		protected virtual void swipeUp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._swipeUp4177); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._swipeUp4177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyboardActionListener4178; 
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnKeyboardActionListener4179; 
		protected virtual global::android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4179)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4179)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyboard4180; 
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setKeyboard4180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setKeyboard4180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyboard4181; 
		public virtual global::android.inputmethodservice.Keyboard getKeyboard() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView._getKeyboard4181)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._getKeyboard4181)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewEnabled4182; 
		public virtual void setPreviewEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPreviewEnabled4182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPreviewEnabled4183; 
		public virtual bool isPreviewEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4183); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isPreviewEnabled4183); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalCorrection4184; 
		public virtual void setVerticalCorrection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setVerticalCorrection4184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPopupParent4185; 
		public virtual void setPopupParent(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPopupParent4185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupParent4185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPopupOffset4186; 
		public virtual void setPopupOffset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setPopupOffset4186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setPopupOffset4186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProximityCorrectionEnabled4187; 
		public virtual void setProximityCorrectionEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProximityCorrectionEnabled4188; 
		public virtual bool isProximityCorrectionEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4188); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4188); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateAllKeys4189; 
		public virtual void invalidateAllKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4189); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateAllKeys4189); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateKey4190; 
		public virtual void invalidateKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.KeyboardView._invalidateKey4190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._invalidateKey4190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLongPress4191; 
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._onLongPress4191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._onLongPress4191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleBack4192; 
		public virtual bool handleBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.KeyboardView._handleBack4192); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._handleBack4192); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView4193; 
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4193, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView4194; 
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, global::android.inputmethodservice.KeyboardView._KeyboardView4194, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.KeyboardView.staticClass = @__class; 
			global::android.inputmethodservice.KeyboardView._closing4165 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V"); 
			global::android.inputmethodservice.KeyboardView._onClick4166 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.KeyboardView._onTouchEvent4167 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow4168 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.inputmethodservice.KeyboardView._onSizeChanged4169 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.inputmethodservice.KeyboardView._onDraw4170 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.inputmethodservice.KeyboardView._onMeasure4171 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V"); 
			global::android.inputmethodservice.KeyboardView._setShifted4172 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z"); 
			global::android.inputmethodservice.KeyboardView._isShifted4173 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z"); 
			global::android.inputmethodservice.KeyboardView._swipeLeft4174 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeRight4175 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeDown4176 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeUp4177 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V"); 
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener4178 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V"); 
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener4179 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;"); 
			global::android.inputmethodservice.KeyboardView._setKeyboard4180 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V"); 
			global::android.inputmethodservice.KeyboardView._getKeyboard4181 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;"); 
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled4182 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V"); 
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled4183 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z"); 
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection4184 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V"); 
			global::android.inputmethodservice.KeyboardView._setPopupParent4185 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.KeyboardView._setPopupOffset4186 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V"); 
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled4187 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V"); 
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled4188 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z"); 
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys4189 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V"); 
			global::android.inputmethodservice.KeyboardView._invalidateKey4190 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V"); 
			global::android.inputmethodservice.KeyboardView._onLongPress4191 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z"); 
			global::android.inputmethodservice.KeyboardView._handleBack4192 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z"); 
			global::android.inputmethodservice.KeyboardView._KeyboardView4193 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.inputmethodservice.KeyboardView._KeyboardView4194 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
