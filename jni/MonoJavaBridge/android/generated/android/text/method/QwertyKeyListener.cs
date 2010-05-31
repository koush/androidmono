namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class QwertyKeyListener : android.text.method.BaseKeyListener
	{
		internal new static global::java.lang.Class staticClass;
		static QwertyKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.QwertyKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.QwertyKeyListener(@__env);
			}
		}
		protected QwertyKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7219;
		public static global::android.text.method.QwertyKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.QwertyKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._getInstance7219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7220;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.QwertyKeyListener._onKeyDown7220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._onKeyDown7220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7221;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.QwertyKeyListener._getInputType7221);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._getInputType7221);
		}
		internal static global::net.sf.jni4net.jni.MethodId _markAsReplaced7222;
		public static void markAsReplaced(android.text.Spannable arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._markAsReplaced7222, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QwertyKeyListener7223;
		public QwertyKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._QwertyKeyListener7223, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.QwertyKeyListener.staticClass = @__class;
			global::android.text.method.QwertyKeyListener._getInstance7219 = @__env.GetStaticMethodID(global::android.text.method.QwertyKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKeyListener;");
			global::android.text.method.QwertyKeyListener._onKeyDown7220 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.QwertyKeyListener._getInputType7221 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.QwertyKeyListener._markAsReplaced7222 = @__env.GetStaticMethodID(global::android.text.method.QwertyKeyListener.staticClass, "markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V");
			global::android.text.method.QwertyKeyListener._QwertyKeyListener7223 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
		}
	}
}
