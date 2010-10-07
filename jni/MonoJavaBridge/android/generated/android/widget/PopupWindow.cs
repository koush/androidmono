namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PopupWindow : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PopupWindow()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.PopupWindow), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.PopupWindow.__OnDismissListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _onDismiss11245;
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.PopupWindow.__OnDismissListener._onDismiss11245);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.__OnDismissListener.staticClass, global::android.widget.PopupWindow.__OnDismissListener._onDismiss11245);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.PopupWindow.__OnDismissListener.staticClass = @__class;
				global::android.widget.PopupWindow.__OnDismissListener._onDismiss11245 = @__env.GetMethodID(global::android.widget.PopupWindow.__OnDismissListener.staticClass, "android.widget.PopupWindow.OnDismissListener.onDismiss", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11246;
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11247;
		public virtual void update() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11247);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11247);
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11248;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11249;
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11250;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _update11251;
		public virtual void update(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._update11251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update11251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth11252;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getWidth11252);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getWidth11252);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight11253;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getHeight11253);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getHeight11253);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView11254;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setContentView11254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setContentView11254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode11255;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setSoftInputMode11255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setSoftInputMode11255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable11256;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setBackgroundDrawable11256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setBackgroundDrawable11256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable11257;
		public virtual void setFocusable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setFocusable11257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setFocusable11257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable11258;
		public virtual bool isFocusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isFocusable11258);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isFocusable11258);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBackground11259;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.PopupWindow._getBackground11259));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getBackground11259));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShowing11260;
		public virtual bool isShowing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isShowing11260);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isShowing11260);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismiss11261;
		public virtual void dismiss() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._dismiss11261);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._dismiss11261);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener11262;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setOnDismissListener11262, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOnDismissListener11262, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeight11263;
		public virtual void setHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setHeight11263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setHeight11263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWidth11264;
		public virtual void setWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setWidth11264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWidth11264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimationStyle11265;
		public virtual int getAnimationStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getAnimationStyle11265);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getAnimationStyle11265);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreCheekPress11266;
		public virtual void setIgnoreCheekPress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setIgnoreCheekPress11266);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setIgnoreCheekPress11266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationStyle11267;
		public virtual void setAnimationStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setAnimationStyle11267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setAnimationStyle11267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentView11268;
		public virtual global::android.view.View getContentView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.PopupWindow._getContentView11268));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getContentView11268));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTouchInterceptor11269;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setTouchInterceptor11269, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchInterceptor11269, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodMode11270;
		public virtual int getInputMethodMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getInputMethodMode11270);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getInputMethodMode11270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethodMode11271;
		public virtual void setInputMethodMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setInputMethodMode11271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setInputMethodMode11271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSoftInputMode11272;
		public virtual int getSoftInputMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getSoftInputMode11272);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getSoftInputMode11272);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTouchable11273;
		public virtual bool isTouchable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isTouchable11273);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isTouchable11273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTouchable11274;
		public virtual void setTouchable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setTouchable11274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchable11274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOutsideTouchable11275;
		public virtual bool isOutsideTouchable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isOutsideTouchable11275);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isOutsideTouchable11275);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutsideTouchable11276;
		public virtual void setOutsideTouchable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setOutsideTouchable11276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOutsideTouchable11276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClippingEnabled11277;
		public virtual bool isClippingEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isClippingEnabled11277);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isClippingEnabled11277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClippingEnabled11278;
		public virtual void setClippingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setClippingEnabled11278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setClippingEnabled11278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWindowLayoutMode11279;
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._setWindowLayoutMode11279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWindowLayoutMode11279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showAtLocation11280;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._showAtLocation11280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAtLocation11280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown11281;
		public virtual void showAsDropDown(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._showAsDropDown11281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown11281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showAsDropDown11282;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.PopupWindow._showAsDropDown11282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown11282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAboveAnchor11283;
		public virtual bool isAboveAnchor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.PopupWindow._isAboveAnchor11283);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isAboveAnchor11283);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight11284;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getMaxAvailableHeight11284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight11284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAvailableHeight11285;
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.PopupWindow._getMaxAvailableHeight11285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight11285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11286;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11286, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11287;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11287, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11288;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11288, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11289;
		public PopupWindow()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11289, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11290;
		public PopupWindow(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11290, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11291;
		public PopupWindow(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11291, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11292;
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11292, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PopupWindow11293;
		public PopupWindow(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow11293, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.widget.PopupWindow._update11246 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V");
			global::android.widget.PopupWindow._update11247 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "()V");
			global::android.widget.PopupWindow._update11248 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V");
			global::android.widget.PopupWindow._update11249 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._update11250 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V");
			global::android.widget.PopupWindow._update11251 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "update", "(II)V");
			global::android.widget.PopupWindow._getWidth11252 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getWidth", "()I");
			global::android.widget.PopupWindow._getHeight11253 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getHeight", "()I");
			global::android.widget.PopupWindow._setContentView11254 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._setSoftInputMode11255 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V");
			global::android.widget.PopupWindow._setBackgroundDrawable11256 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.PopupWindow._setFocusable11257 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V");
			global::android.widget.PopupWindow._isFocusable11258 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z");
			global::android.widget.PopupWindow._getBackground11259 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.PopupWindow._isShowing11260 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z");
			global::android.widget.PopupWindow._dismiss11261 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "dismiss", "()V");
			global::android.widget.PopupWindow._setOnDismissListener11262 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			global::android.widget.PopupWindow._setHeight11263 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V");
			global::android.widget.PopupWindow._setWidth11264 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V");
			global::android.widget.PopupWindow._getAnimationStyle11265 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I");
			global::android.widget.PopupWindow._setIgnoreCheekPress11266 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V");
			global::android.widget.PopupWindow._setAnimationStyle11267 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V");
			global::android.widget.PopupWindow._getContentView11268 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;");
			global::android.widget.PopupWindow._setTouchInterceptor11269 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V");
			global::android.widget.PopupWindow._getInputMethodMode11270 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I");
			global::android.widget.PopupWindow._setInputMethodMode11271 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V");
			global::android.widget.PopupWindow._getSoftInputMode11272 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I");
			global::android.widget.PopupWindow._isTouchable11273 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z");
			global::android.widget.PopupWindow._setTouchable11274 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V");
			global::android.widget.PopupWindow._isOutsideTouchable11275 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z");
			global::android.widget.PopupWindow._setOutsideTouchable11276 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V");
			global::android.widget.PopupWindow._isClippingEnabled11277 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z");
			global::android.widget.PopupWindow._setClippingEnabled11278 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V");
			global::android.widget.PopupWindow._setWindowLayoutMode11279 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V");
			global::android.widget.PopupWindow._showAtLocation11280 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V");
			global::android.widget.PopupWindow._showAsDropDown11281 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._showAsDropDown11282 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._isAboveAnchor11283 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z");
			global::android.widget.PopupWindow._getMaxAvailableHeight11284 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I");
			global::android.widget.PopupWindow._getMaxAvailableHeight11285 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I");
			global::android.widget.PopupWindow._PopupWindow11286 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::android.widget.PopupWindow._PopupWindow11287 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.PopupWindow._PopupWindow11288 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.PopupWindow._PopupWindow11289 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::android.widget.PopupWindow._PopupWindow11290 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._PopupWindow11291 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::android.widget.PopupWindow._PopupWindow11292 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._PopupWindow11293 = @__env.GetMethodID(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
