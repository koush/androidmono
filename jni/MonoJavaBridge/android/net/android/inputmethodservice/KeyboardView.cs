namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyboardView : android.view.View, android.view.View.OnClickListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static KeyboardView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.KeyboardView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _closing3942; 
		public virtual void closing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _closing3942); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _closing3942); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick3943; 
		public virtual void onClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _onClick3943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onClick3943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent3944; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent3944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onTouchEvent3944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow3945; 
		public virtual new void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow3945); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onDetachedFromWindow3945); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged3946; 
		public virtual new void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _onSizeChanged3946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onSizeChanged3946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw3947; 
		public virtual new void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _onDraw3947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onDraw3947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure3948; 
		public virtual new void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _onMeasure3948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onMeasure3948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShifted3949; 
		public virtual bool setShifted(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _setShifted3949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setShifted3949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShifted3950; 
		public virtual bool isShifted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _isShifted3950); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _isShifted3950); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeLeft3951; 
		protected virtual void swipeLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _swipeLeft3951); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _swipeLeft3951); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeRight3952; 
		protected virtual void swipeRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _swipeRight3952); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _swipeRight3952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeDown3953; 
		protected virtual void swipeDown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _swipeDown3953); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _swipeDown3953); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _swipeUp3954; 
		protected virtual void swipeUp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _swipeUp3954); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _swipeUp3954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyboardActionListener3955; 
		public virtual void setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setOnKeyboardActionListener3955, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setOnKeyboardActionListener3955, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnKeyboardActionListener3956; 
		protected virtual android.inputmethodservice.KeyboardView.OnKeyboardActionListener getOnKeyboardActionListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnKeyboardActionListener3956)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.inputmethodservice.KeyboardView.OnKeyboardActionListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.KeyboardView.staticClass, _getOnKeyboardActionListener3956)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyboard3957; 
		public virtual void setKeyboard(android.inputmethodservice.Keyboard arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setKeyboard3957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setKeyboard3957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyboard3958; 
		public virtual android.inputmethodservice.Keyboard getKeyboard() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallObjectMethodPtr(this, _getKeyboard3958)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.KeyboardView.staticClass, _getKeyboard3958)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewEnabled3959; 
		public virtual void setPreviewEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setPreviewEnabled3959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setPreviewEnabled3959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPreviewEnabled3960; 
		public virtual bool isPreviewEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _isPreviewEnabled3960); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _isPreviewEnabled3960); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalCorrection3961; 
		public virtual void setVerticalCorrection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setVerticalCorrection3961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setVerticalCorrection3961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPopupParent3962; 
		public virtual void setPopupParent(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setPopupParent3962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setPopupParent3962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPopupOffset3963; 
		public virtual void setPopupOffset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setPopupOffset3963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setPopupOffset3963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProximityCorrectionEnabled3964; 
		public virtual void setProximityCorrectionEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _setProximityCorrectionEnabled3964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _setProximityCorrectionEnabled3964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProximityCorrectionEnabled3965; 
		public virtual bool isProximityCorrectionEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _isProximityCorrectionEnabled3965); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _isProximityCorrectionEnabled3965); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateAllKeys3966; 
		public virtual void invalidateAllKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _invalidateAllKeys3966); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _invalidateAllKeys3966); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateKey3967; 
		public virtual void invalidateKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				@__env.CallVoidMethod(this, _invalidateKey3967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.KeyboardView.staticClass, _invalidateKey3967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLongPress3968; 
		protected virtual bool onLongPress(android.inputmethodservice.Keyboard.Key arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _onLongPress3968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _onLongPress3968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleBack3969; 
		public virtual bool handleBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.KeyboardView)) 
				return @__env.CallBooleanMethod(this, _handleBack3969); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.KeyboardView.staticClass, _handleBack3969); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView3970; 
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, _KeyboardView3970, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyboardView3971; 
		public KeyboardView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.KeyboardView.staticClass, _KeyboardView3971, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.KeyboardView.staticClass = @__class; 
			global::android.inputmethodservice.KeyboardView._closing3942 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "closing", "()V"); 
			global::android.inputmethodservice.KeyboardView._onClick3943 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.KeyboardView._onTouchEvent3944 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.inputmethodservice.KeyboardView._onDetachedFromWindow3945 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.inputmethodservice.KeyboardView._onSizeChanged3946 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.inputmethodservice.KeyboardView._onDraw3947 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.inputmethodservice.KeyboardView._onMeasure3948 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onMeasure", "(II)V"); 
			global::android.inputmethodservice.KeyboardView._setShifted3949 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setShifted", "(Z)Z"); 
			global::android.inputmethodservice.KeyboardView._isShifted3950 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isShifted", "()Z"); 
			global::android.inputmethodservice.KeyboardView._swipeLeft3951 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeLeft", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeRight3952 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeRight", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeDown3953 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeDown", "()V"); 
			global::android.inputmethodservice.KeyboardView._swipeUp3954 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "swipeUp", "()V"); 
			global::android.inputmethodservice.KeyboardView._setOnKeyboardActionListener3955 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V"); 
			global::android.inputmethodservice.KeyboardView._getOnKeyboardActionListener3956 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;"); 
			global::android.inputmethodservice.KeyboardView._setKeyboard3957 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V"); 
			global::android.inputmethodservice.KeyboardView._getKeyboard3958 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "getKeyboard", "()Landroid/inputmethodservice/Keyboard;"); 
			global::android.inputmethodservice.KeyboardView._setPreviewEnabled3959 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPreviewEnabled", "(Z)V"); 
			global::android.inputmethodservice.KeyboardView._isPreviewEnabled3960 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isPreviewEnabled", "()Z"); 
			global::android.inputmethodservice.KeyboardView._setVerticalCorrection3961 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setVerticalCorrection", "(I)V"); 
			global::android.inputmethodservice.KeyboardView._setPopupParent3962 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupParent", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.KeyboardView._setPopupOffset3963 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setPopupOffset", "(II)V"); 
			global::android.inputmethodservice.KeyboardView._setProximityCorrectionEnabled3964 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "setProximityCorrectionEnabled", "(Z)V"); 
			global::android.inputmethodservice.KeyboardView._isProximityCorrectionEnabled3965 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "isProximityCorrectionEnabled", "()Z"); 
			global::android.inputmethodservice.KeyboardView._invalidateAllKeys3966 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateAllKeys", "()V"); 
			global::android.inputmethodservice.KeyboardView._invalidateKey3967 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "invalidateKey", "(I)V"); 
			global::android.inputmethodservice.KeyboardView._onLongPress3968 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z"); 
			global::android.inputmethodservice.KeyboardView._handleBack3969 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "handleBack", "()Z"); 
			global::android.inputmethodservice.KeyboardView._KeyboardView3970 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.inputmethodservice.KeyboardView._KeyboardView3971 = @__env.GetMethodID(global::android.inputmethodservice.KeyboardView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
