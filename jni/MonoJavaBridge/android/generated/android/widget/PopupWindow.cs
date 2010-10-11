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
			internal static global::MonoJavaBridge.MethodId _onDismiss11624;
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_._onDismiss11624);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_.staticClass, global::android.widget.PopupWindow.OnDismissListener_._onDismiss11624);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow$OnDismissListener"));
				global::android.widget.PopupWindow.OnDismissListener_._onDismiss11624 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _update11625;
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update11626;
		public virtual void update() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11626);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11626);
		}
		internal static global::MonoJavaBridge.MethodId _update11627;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update11628;
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update11629;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update11630;
		public virtual void update(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update11630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth11631;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getWidth11631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getWidth11631);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight11632;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getHeight11632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getHeight11632);
		}
		internal static global::MonoJavaBridge.MethodId _setContentView11633;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setContentView11633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setContentView11633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode11634;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setSoftInputMode11634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setSoftInputMode11634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable11635;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setBackgroundDrawable11635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setBackgroundDrawable11635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable11636;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setFocusable11636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setFocusable11636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable11637;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isFocusable11637);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isFocusable11637);
		}
		internal static global::MonoJavaBridge.MethodId _getBackground11638;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getBackground11638)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getBackground11638)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing11639;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isShowing11639);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isShowing11639);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss11640;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._dismiss11640);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._dismiss11640);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener11641;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOnDismissListener11641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOnDismissListener11641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight11642;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setHeight11642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setHeight11642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth11643;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWidth11643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWidth11643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationStyle11644;
		public virtual int getAnimationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getAnimationStyle11644);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getAnimationStyle11644);
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreCheekPress11645;
		public virtual void setIgnoreCheekPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setIgnoreCheekPress11645);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setIgnoreCheekPress11645);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationStyle11646;
		public virtual void setAnimationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setAnimationStyle11646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setAnimationStyle11646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentView11647;
		public virtual global::android.view.View getContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getContentView11647)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getContentView11647)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setTouchInterceptor11648;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchInterceptor11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchInterceptor11648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputMethodMode11649;
		public virtual int getInputMethodMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getInputMethodMode11649);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getInputMethodMode11649);
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethodMode11650;
		public virtual void setInputMethodMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setInputMethodMode11650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setInputMethodMode11650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSoftInputMode11651;
		public virtual int getSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getSoftInputMode11651);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getSoftInputMode11651);
		}
		internal static global::MonoJavaBridge.MethodId _isTouchable11652;
		public virtual bool isTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isTouchable11652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isTouchable11652);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchable11653;
		public virtual void setTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchable11653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchable11653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOutsideTouchable11654;
		public virtual bool isOutsideTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isOutsideTouchable11654);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isOutsideTouchable11654);
		}
		internal static global::MonoJavaBridge.MethodId _setOutsideTouchable11655;
		public virtual void setOutsideTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOutsideTouchable11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOutsideTouchable11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClippingEnabled11656;
		public virtual bool isClippingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isClippingEnabled11656);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isClippingEnabled11656);
		}
		internal static global::MonoJavaBridge.MethodId _setClippingEnabled11657;
		public virtual void setClippingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setClippingEnabled11657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setClippingEnabled11657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowLayoutMode11658;
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWindowLayoutMode11658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWindowLayoutMode11658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showAtLocation11659;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAtLocation11659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAtLocation11659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown11660;
		public virtual void showAsDropDown(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown11660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown11660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown11661;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isAboveAnchor11662;
		public virtual bool isAboveAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isAboveAnchor11662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isAboveAnchor11662);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight11663;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight11664;
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight11664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight11664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11665;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11666;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11667;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11668;
		public PopupWindow()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11668);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11669;
		public PopupWindow(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11670;
		public PopupWindow(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11671;
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow11672;
		public PopupWindow(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.PopupWindow._update11625 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V");
			global::android.widget.PopupWindow._update11626 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "()V");
			global::android.widget.PopupWindow._update11627 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V");
			global::android.widget.PopupWindow._update11628 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._update11629 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V");
			global::android.widget.PopupWindow._update11630 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(II)V");
			global::android.widget.PopupWindow._getWidth11631 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getWidth", "()I");
			global::android.widget.PopupWindow._getHeight11632 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getHeight", "()I");
			global::android.widget.PopupWindow._setContentView11633 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._setSoftInputMode11634 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V");
			global::android.widget.PopupWindow._setBackgroundDrawable11635 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.PopupWindow._setFocusable11636 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V");
			global::android.widget.PopupWindow._isFocusable11637 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z");
			global::android.widget.PopupWindow._getBackground11638 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.PopupWindow._isShowing11639 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z");
			global::android.widget.PopupWindow._dismiss11640 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "dismiss", "()V");
			global::android.widget.PopupWindow._setOnDismissListener11641 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			global::android.widget.PopupWindow._setHeight11642 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V");
			global::android.widget.PopupWindow._setWidth11643 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V");
			global::android.widget.PopupWindow._getAnimationStyle11644 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I");
			global::android.widget.PopupWindow._setIgnoreCheekPress11645 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V");
			global::android.widget.PopupWindow._setAnimationStyle11646 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V");
			global::android.widget.PopupWindow._getContentView11647 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;");
			global::android.widget.PopupWindow._setTouchInterceptor11648 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V");
			global::android.widget.PopupWindow._getInputMethodMode11649 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I");
			global::android.widget.PopupWindow._setInputMethodMode11650 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V");
			global::android.widget.PopupWindow._getSoftInputMode11651 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I");
			global::android.widget.PopupWindow._isTouchable11652 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z");
			global::android.widget.PopupWindow._setTouchable11653 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V");
			global::android.widget.PopupWindow._isOutsideTouchable11654 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z");
			global::android.widget.PopupWindow._setOutsideTouchable11655 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V");
			global::android.widget.PopupWindow._isClippingEnabled11656 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z");
			global::android.widget.PopupWindow._setClippingEnabled11657 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V");
			global::android.widget.PopupWindow._setWindowLayoutMode11658 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V");
			global::android.widget.PopupWindow._showAtLocation11659 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V");
			global::android.widget.PopupWindow._showAsDropDown11660 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._showAsDropDown11661 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._isAboveAnchor11662 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z");
			global::android.widget.PopupWindow._getMaxAvailableHeight11663 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I");
			global::android.widget.PopupWindow._getMaxAvailableHeight11664 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I");
			global::android.widget.PopupWindow._PopupWindow11665 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::android.widget.PopupWindow._PopupWindow11666 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.PopupWindow._PopupWindow11667 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.PopupWindow._PopupWindow11668 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::android.widget.PopupWindow._PopupWindow11669 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._PopupWindow11670 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::android.widget.PopupWindow._PopupWindow11671 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._PopupWindow11672 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
