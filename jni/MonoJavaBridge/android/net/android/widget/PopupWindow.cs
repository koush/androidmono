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

		public partial class OnDismissListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnDismissListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnDismissListener : java.lang.Object, OnDismissListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnDismissListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.PopupWindow.__OnDismissListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.PopupWindow.__OnDismissListener(@__env); 
				} 
			} 
			internal __OnDismissListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDismiss10535; 
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.PopupWindow.__OnDismissListener)) 
					@__env.CallVoidMethod(this, _onDismiss10535); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.__OnDismissListener.staticClass, _onDismiss10535); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.PopupWindow.__OnDismissListener.staticClass = @__class; 
				global::android.widget.PopupWindow.__OnDismissListener._onDismiss10535 = @__env.GetMethodID(global::android.widget.PopupWindow.__OnDismissListener.staticClass, "android.widget.PopupWindow.OnDismissListener.onDismiss", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10536; 
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10537; 
		public virtual void update() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10537); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10537); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10538; 
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10539; 
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10540; 
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update10541; 
		public virtual void update(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _update10541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _update10541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth10542; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getWidth10542); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getWidth10542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight10543; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getHeight10543); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getHeight10543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView10544; 
		public virtual void setContentView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setContentView10544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setContentView10544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode10545; 
		public virtual void setSoftInputMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setSoftInputMode10545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setSoftInputMode10545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable10546; 
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setBackgroundDrawable10546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setBackgroundDrawable10546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable10547; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setFocusable10547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setFocusable10547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable10548; 
		public virtual bool isFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isFocusable10548); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isFocusable10548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackground10549; 
		public virtual android.graphics.drawable.Drawable getBackground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getBackground10549)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.PopupWindow.staticClass, _getBackground10549)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing10550; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isShowing10550); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isShowing10550); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismiss10551; 
		public virtual void dismiss() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _dismiss10551); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _dismiss10551); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener10552; 
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setOnDismissListener10552, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setOnDismissListener10552, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHeight10553; 
		public virtual void setHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setHeight10553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setHeight10553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWidth10554; 
		public virtual void setWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setWidth10554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setWidth10554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimationStyle10555; 
		public virtual int getAnimationStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getAnimationStyle10555); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getAnimationStyle10555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreCheekPress10556; 
		public virtual void setIgnoreCheekPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setIgnoreCheekPress10556); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setIgnoreCheekPress10556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationStyle10557; 
		public virtual void setAnimationStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setAnimationStyle10557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setAnimationStyle10557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentView10558; 
		public virtual android.view.View getContentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getContentView10558)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.PopupWindow.staticClass, _getContentView10558)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchInterceptor10559; 
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setTouchInterceptor10559, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setTouchInterceptor10559, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodMode10560; 
		public virtual int getInputMethodMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getInputMethodMode10560); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getInputMethodMode10560); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethodMode10561; 
		public virtual void setInputMethodMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setInputMethodMode10561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setInputMethodMode10561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoftInputMode10562; 
		public virtual int getSoftInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getSoftInputMode10562); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getSoftInputMode10562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTouchable10563; 
		public virtual bool isTouchable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isTouchable10563); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isTouchable10563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchable10564; 
		public virtual void setTouchable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setTouchable10564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setTouchable10564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutsideTouchable10565; 
		public virtual bool isOutsideTouchable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isOutsideTouchable10565); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isOutsideTouchable10565); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutsideTouchable10566; 
		public virtual void setOutsideTouchable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setOutsideTouchable10566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setOutsideTouchable10566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClippingEnabled10567; 
		public virtual bool isClippingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isClippingEnabled10567); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isClippingEnabled10567); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClippingEnabled10568; 
		public virtual void setClippingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setClippingEnabled10568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setClippingEnabled10568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowLayoutMode10569; 
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _setWindowLayoutMode10569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _setWindowLayoutMode10569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAtLocation10570; 
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAtLocation10570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAtLocation10570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown10571; 
		public virtual void showAsDropDown(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAsDropDown10571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAsDropDown10571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown10572; 
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				@__env.CallVoidMethod(this, _showAsDropDown10572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.PopupWindow.staticClass, _showAsDropDown10572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAboveAnchor10573; 
		public virtual bool isAboveAnchor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallBooleanMethod(this, _isAboveAnchor10573); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.PopupWindow.staticClass, _isAboveAnchor10573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight10574; 
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getMaxAvailableHeight10574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getMaxAvailableHeight10574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight10575; 
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.PopupWindow)) 
				return @__env.CallIntMethod(this, _getMaxAvailableHeight10575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.PopupWindow.staticClass, _getMaxAvailableHeight10575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10576; 
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10576, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10577; 
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10577, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10578; 
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10578, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10579; 
		public PopupWindow()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10579, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10580; 
		public PopupWindow(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10580, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10581; 
		public PopupWindow(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10581, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10582; 
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10582, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow10583; 
		public PopupWindow(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.PopupWindow.staticClass, _PopupWindow10583, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.widget.PopupWindow._update10536 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V"); 
			global::android.widget.PopupWindow._update10537 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "()V"); 
			global::android.widget.PopupWindow._update10538 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V"); 
			global::android.widget.PopupWindow._update10539 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._update10540 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V"); 
			global::android.widget.PopupWindow._update10541 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(II)V"); 
			global::android.widget.PopupWindow._getWidth10542 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getWidth", "()I"); 
			global::android.widget.PopupWindow._getHeight10543 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getHeight", "()I"); 
			global::android.widget.PopupWindow._setContentView10544 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._setSoftInputMode10545 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V"); 
			global::android.widget.PopupWindow._setBackgroundDrawable10546 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.PopupWindow._setFocusable10547 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.PopupWindow._isFocusable10548 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z"); 
			global::android.widget.PopupWindow._getBackground10549 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.PopupWindow._isShowing10550 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z"); 
			global::android.widget.PopupWindow._dismiss10551 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "dismiss", "()V"); 
			global::android.widget.PopupWindow._setOnDismissListener10552 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V"); 
			global::android.widget.PopupWindow._setHeight10553 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V"); 
			global::android.widget.PopupWindow._setWidth10554 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V"); 
			global::android.widget.PopupWindow._getAnimationStyle10555 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I"); 
			global::android.widget.PopupWindow._setIgnoreCheekPress10556 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V"); 
			global::android.widget.PopupWindow._setAnimationStyle10557 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V"); 
			global::android.widget.PopupWindow._getContentView10558 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;"); 
			global::android.widget.PopupWindow._setTouchInterceptor10559 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V"); 
			global::android.widget.PopupWindow._getInputMethodMode10560 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I"); 
			global::android.widget.PopupWindow._setInputMethodMode10561 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V"); 
			global::android.widget.PopupWindow._getSoftInputMode10562 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I"); 
			global::android.widget.PopupWindow._isTouchable10563 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z"); 
			global::android.widget.PopupWindow._setTouchable10564 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V"); 
			global::android.widget.PopupWindow._isOutsideTouchable10565 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z"); 
			global::android.widget.PopupWindow._setOutsideTouchable10566 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V"); 
			global::android.widget.PopupWindow._isClippingEnabled10567 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z"); 
			global::android.widget.PopupWindow._setClippingEnabled10568 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V"); 
			global::android.widget.PopupWindow._setWindowLayoutMode10569 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V"); 
			global::android.widget.PopupWindow._showAtLocation10570 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V"); 
			global::android.widget.PopupWindow._showAsDropDown10571 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._showAsDropDown10572 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._isAboveAnchor10573 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z"); 
			global::android.widget.PopupWindow._getMaxAvailableHeight10574 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I"); 
			global::android.widget.PopupWindow._getMaxAvailableHeight10575 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I"); 
			global::android.widget.PopupWindow._PopupWindow10576 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V"); 
			global::android.widget.PopupWindow._PopupWindow10577 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.PopupWindow._PopupWindow10578 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.PopupWindow._PopupWindow10579 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "()V"); 
			global::android.widget.PopupWindow._PopupWindow10580 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V"); 
			global::android.widget.PopupWindow._PopupWindow10581 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V"); 
			global::android.widget.PopupWindow._PopupWindow10582 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V"); 
			global::android.widget.PopupWindow._PopupWindow10583 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
