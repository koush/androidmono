namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PopupWindow : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PopupWindow() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.PopupWindow), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.PopupWindow(@__env); 
			} 
		} 
		protected PopupWindow(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDismissListener 
		{ 
			void onDismiss(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9766; 
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9767; 
		public virtual void update() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9767); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9767); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9768; 
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9769; 
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9770; 
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update9771; 
		public virtual void update(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update9771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update9771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth9772; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getWidth9772); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getWidth9772); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight9773; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getHeight9773); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getHeight9773); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView9774; 
		public virtual void setContentView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setContentView9774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setContentView9774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode9775; 
		public virtual void setSoftInputMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setSoftInputMode9775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setSoftInputMode9775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable9776; 
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setBackgroundDrawable9776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setBackgroundDrawable9776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable9777; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setFocusable9777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setFocusable9777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable9778; 
		public virtual bool isFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isFocusable9778); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isFocusable9778); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackground9779; 
		public virtual android.graphics.drawable.Drawable getBackground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getBackground9779)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.PopupWindow.staticClass, _getBackground9779)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing9780; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isShowing9780); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isShowing9780); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismiss9781; 
		public virtual void dismiss() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _dismiss9781); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _dismiss9781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener9782; 
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setOnDismissListener9782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setOnDismissListener9782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHeight9783; 
		public virtual void setHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setHeight9783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setHeight9783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWidth9784; 
		public virtual void setWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setWidth9784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setWidth9784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimationStyle9785; 
		public virtual int getAnimationStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getAnimationStyle9785); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getAnimationStyle9785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreCheekPress9786; 
		public virtual void setIgnoreCheekPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setIgnoreCheekPress9786); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setIgnoreCheekPress9786); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationStyle9787; 
		public virtual void setAnimationStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setAnimationStyle9787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setAnimationStyle9787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentView9788; 
		public virtual android.view.View getContentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getContentView9788)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.PopupWindow.staticClass, _getContentView9788)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchInterceptor9789; 
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setTouchInterceptor9789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setTouchInterceptor9789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodMode9790; 
		public virtual int getInputMethodMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getInputMethodMode9790); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getInputMethodMode9790); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethodMode9791; 
		public virtual void setInputMethodMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setInputMethodMode9791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setInputMethodMode9791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoftInputMode9792; 
		public virtual int getSoftInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getSoftInputMode9792); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getSoftInputMode9792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTouchable9793; 
		public virtual bool isTouchable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isTouchable9793); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isTouchable9793); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchable9794; 
		public virtual void setTouchable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setTouchable9794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setTouchable9794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutsideTouchable9795; 
		public virtual bool isOutsideTouchable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isOutsideTouchable9795); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isOutsideTouchable9795); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutsideTouchable9796; 
		public virtual void setOutsideTouchable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setOutsideTouchable9796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setOutsideTouchable9796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClippingEnabled9797; 
		public virtual bool isClippingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isClippingEnabled9797); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isClippingEnabled9797); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClippingEnabled9798; 
		public virtual void setClippingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setClippingEnabled9798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setClippingEnabled9798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowLayoutMode9799; 
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setWindowLayoutMode9799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setWindowLayoutMode9799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAtLocation9800; 
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAtLocation9800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAtLocation9800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown9801; 
		public virtual void showAsDropDown(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAsDropDown9801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAsDropDown9801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown9802; 
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAsDropDown9802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAsDropDown9802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAboveAnchor9803; 
		public virtual bool isAboveAnchor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isAboveAnchor9803); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isAboveAnchor9803); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight9804; 
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getMaxAvailableHeight9804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getMaxAvailableHeight9804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight9805; 
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getMaxAvailableHeight9805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getMaxAvailableHeight9805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9806; 
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9806, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9807; 
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9807, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9808; 
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9808, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9809; 
		public PopupWindow()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9809, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9810; 
		public PopupWindow(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9810, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9811; 
		public PopupWindow(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9811, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9812; 
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9812, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow9813; 
		public PopupWindow(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow9813, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.PopupWindow.staticClass = @__class; 
			global::android.widget.PopupWindow._update9766 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V"); 
			global::android.widget.PopupWindow._update9767 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "()V"); 
			global::android.widget.PopupWindow._update9768 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V"); 
			global::android.widget.PopupWindow._update9769 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._update9770 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V"); 
			global::android.widget.PopupWindow._update9771 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(II)V"); 
			global::android.widget.PopupWindow._getWidth9772 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getWidth", "()I"); 
			global::android.widget.PopupWindow._getHeight9773 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getHeight", "()I"); 
			global::android.widget.PopupWindow._setContentView9774 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._setSoftInputMode9775 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V"); 
			global::android.widget.PopupWindow._setBackgroundDrawable9776 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.PopupWindow._setFocusable9777 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.PopupWindow._isFocusable9778 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z"); 
			global::android.widget.PopupWindow._getBackground9779 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.PopupWindow._isShowing9780 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z"); 
			global::android.widget.PopupWindow._dismiss9781 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "dismiss", "()V"); 
			global::android.widget.PopupWindow._setOnDismissListener9782 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V"); 
			global::android.widget.PopupWindow._setHeight9783 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V"); 
			global::android.widget.PopupWindow._setWidth9784 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V"); 
			global::android.widget.PopupWindow._getAnimationStyle9785 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I"); 
			global::android.widget.PopupWindow._setIgnoreCheekPress9786 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V"); 
			global::android.widget.PopupWindow._setAnimationStyle9787 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V"); 
			global::android.widget.PopupWindow._getContentView9788 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;"); 
			global::android.widget.PopupWindow._setTouchInterceptor9789 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V"); 
			global::android.widget.PopupWindow._getInputMethodMode9790 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I"); 
			global::android.widget.PopupWindow._setInputMethodMode9791 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V"); 
			global::android.widget.PopupWindow._getSoftInputMode9792 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I"); 
			global::android.widget.PopupWindow._isTouchable9793 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z"); 
			global::android.widget.PopupWindow._setTouchable9794 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V"); 
			global::android.widget.PopupWindow._isOutsideTouchable9795 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z"); 
			global::android.widget.PopupWindow._setOutsideTouchable9796 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V"); 
			global::android.widget.PopupWindow._isClippingEnabled9797 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z"); 
			global::android.widget.PopupWindow._setClippingEnabled9798 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V"); 
			global::android.widget.PopupWindow._setWindowLayoutMode9799 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V"); 
			global::android.widget.PopupWindow._showAtLocation9800 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V"); 
			global::android.widget.PopupWindow._showAsDropDown9801 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._showAsDropDown9802 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._isAboveAnchor9803 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z"); 
			global::android.widget.PopupWindow._getMaxAvailableHeight9804 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I"); 
			global::android.widget.PopupWindow._getMaxAvailableHeight9805 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I"); 
			global::android.widget.PopupWindow._PopupWindow9806 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V"); 
			global::android.widget.PopupWindow._PopupWindow9807 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.PopupWindow._PopupWindow9808 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.PopupWindow._PopupWindow9809 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "()V"); 
			global::android.widget.PopupWindow._PopupWindow9810 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._PopupWindow9811 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V"); 
			global::android.widget.PopupWindow._PopupWindow9812 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._PopupWindow9813 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
