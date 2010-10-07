namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface KeyListener 
	{
		bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		int getInputType();
		bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2);
		void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2);
	}

	public partial class KeyListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __KeyListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __KeyListener : java.lang.Object, KeyListener
	{
		internal static global::java.lang.Class staticClass;
		static __KeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.__KeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.__KeyListener(@__env);
			}
		}
		internal __KeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7782;
		 bool android.text.method.KeyListener.onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__KeyListener._onKeyDown7782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__KeyListener.staticClass, global::android.text.method.__KeyListener._onKeyDown7782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7783;
		 bool android.text.method.KeyListener.onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__KeyListener._onKeyUp7783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__KeyListener.staticClass, global::android.text.method.__KeyListener._onKeyUp7783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7784;
		 int android.text.method.KeyListener.getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.__KeyListener._getInputType7784);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.__KeyListener.staticClass, global::android.text.method.__KeyListener._getInputType7784);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther7785;
		 bool android.text.method.KeyListener.onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__KeyListener._onKeyOther7785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__KeyListener.staticClass, global::android.text.method.__KeyListener._onKeyOther7785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState7786;
		 void android.text.method.KeyListener.clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.__KeyListener._clearMetaKeyState7786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.__KeyListener.staticClass, global::android.text.method.__KeyListener._clearMetaKeyState7786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.__KeyListener.staticClass = @__class;
			global::android.text.method.__KeyListener._onKeyDown7782 = @__env.GetMethodID(global::android.text.method.__KeyListener.staticClass, "android.text.method.KeyListener.onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.__KeyListener._onKeyUp7783 = @__env.GetMethodID(global::android.text.method.__KeyListener.staticClass, "android.text.method.KeyListener.onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.__KeyListener._getInputType7784 = @__env.GetMethodID(global::android.text.method.__KeyListener.staticClass, "android.text.method.KeyListener.getInputType", "()I");
			global::android.text.method.__KeyListener._onKeyOther7785 = @__env.GetMethodID(global::android.text.method.__KeyListener.staticClass, "android.text.method.KeyListener.onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.__KeyListener._clearMetaKeyState7786 = @__env.GetMethodID(global::android.text.method.__KeyListener.staticClass, "android.text.method.KeyListener.clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V");
		}
	}
}
