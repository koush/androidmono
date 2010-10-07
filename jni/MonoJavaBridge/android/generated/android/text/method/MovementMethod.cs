namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface MovementMethod 
	{
		void initialize(android.widget.TextView arg0, android.text.Spannable arg1);
		bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3);
		bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3);
		bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2);
		bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2);
		bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2);
		void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2);
		bool canSelectArbitrarily();
	}

	public partial class MovementMethod_
	{
		public static global::java.lang.Class _class
		{
			get { return __MovementMethod.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __MovementMethod : java.lang.Object, MovementMethod
	{
		internal static global::java.lang.Class staticClass;
		static __MovementMethod()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.__MovementMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.__MovementMethod(@__env);
			}
		}
		internal __MovementMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _initialize7817;
		 void android.text.method.MovementMethod.initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.__MovementMethod._initialize7817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._initialize7817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7818;
		 bool android.text.method.MovementMethod.onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._onKeyDown7818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onKeyDown7818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7819;
		 bool android.text.method.MovementMethod.onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._onKeyUp7819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onKeyUp7819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent7820;
		 bool android.text.method.MovementMethod.onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._onTouchEvent7820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onTouchEvent7820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent7821;
		 bool android.text.method.MovementMethod.onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._onTrackballEvent7821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onTrackballEvent7821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther7822;
		 bool android.text.method.MovementMethod.onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._onKeyOther7822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onKeyOther7822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTakeFocus7823;
		 void android.text.method.MovementMethod.onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.__MovementMethod._onTakeFocus7823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._onTakeFocus7823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canSelectArbitrarily7824;
		 bool android.text.method.MovementMethod.canSelectArbitrarily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.__MovementMethod._canSelectArbitrarily7824);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.__MovementMethod.staticClass, global::android.text.method.__MovementMethod._canSelectArbitrarily7824);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.__MovementMethod.staticClass = @__class;
			global::android.text.method.__MovementMethod._initialize7817 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::android.text.method.__MovementMethod._onKeyDown7818 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.__MovementMethod._onKeyUp7819 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.__MovementMethod._onTouchEvent7820 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.__MovementMethod._onTrackballEvent7821 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.__MovementMethod._onKeyOther7822 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.__MovementMethod._onTakeFocus7823 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::android.text.method.__MovementMethod._canSelectArbitrarily7824 = @__env.GetMethodID(global::android.text.method.__MovementMethod.staticClass, "android.text.method.MovementMethod.canSelectArbitrarily", "()Z");
		}
	}
}
