namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class BaseKeyListener : android.text.method.MetaKeyKeyListener, KeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BaseKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.BaseKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected BaseKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6764; 
		public abstract int getInputType(); 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6765; 
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.BaseKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.BaseKeyListener.staticClass, _onKeyDown6765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther6766; 
		public virtual bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.BaseKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyOther6766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.BaseKeyListener.staticClass, _onKeyOther6766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _backspace6767; 
		public virtual bool backspace(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.BaseKeyListener)) 
				return @__env.CallBooleanMethod(this, _backspace6767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.BaseKeyListener.staticClass, _backspace6767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BaseKeyListener6768; 
		public BaseKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.BaseKeyListener.staticClass, _BaseKeyListener6768, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.BaseKeyListener.staticClass = @__class; 
			global::android.text.method.BaseKeyListener._getInputType6764 = @__env.GetMethodID(global::android.text.method.BaseKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.BaseKeyListener._onKeyDown6765 = @__env.GetMethodID(global::android.text.method.BaseKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.BaseKeyListener._onKeyOther6766 = @__env.GetMethodID(global::android.text.method.BaseKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z"); 
			global::android.text.method.BaseKeyListener._backspace6767 = @__env.GetMethodID(global::android.text.method.BaseKeyListener.staticClass, "backspace", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.BaseKeyListener._BaseKeyListener6768 = @__env.GetMethodID(global::android.text.method.BaseKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
