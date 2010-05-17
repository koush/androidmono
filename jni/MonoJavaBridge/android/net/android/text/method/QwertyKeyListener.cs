namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class QwertyKeyListener : android.text.method.BaseKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static QwertyKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.QwertyKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6851; 
		public static android.text.method.QwertyKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.QwertyKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.QwertyKeyListener.staticClass, _getInstance6851, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6852; 
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.QwertyKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.QwertyKeyListener.staticClass, _onKeyDown6852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6853; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.QwertyKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6853); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.QwertyKeyListener.staticClass, _getInputType6853); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markAsReplaced6854; 
		public static void markAsReplaced(android.text.Spannable arg0, int arg1, int arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.QwertyKeyListener.staticClass, _markAsReplaced6854, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _QwertyKeyListener6855; 
		public QwertyKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.QwertyKeyListener.staticClass, _QwertyKeyListener6855, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.QwertyKeyListener.staticClass = @__class; 
			global::android.text.method.QwertyKeyListener._getInstance6851 = @__env.GetStaticMethodID(global::android.text.method.QwertyKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKeyListener;"); 
			global::android.text.method.QwertyKeyListener._onKeyDown6852 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.QwertyKeyListener._getInputType6853 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.QwertyKeyListener._markAsReplaced6854 = @__env.GetStaticMethodID(global::android.text.method.QwertyKeyListener.staticClass, "markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V"); 
			global::android.text.method.QwertyKeyListener._QwertyKeyListener6855 = @__env.GetMethodID(global::android.text.method.QwertyKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V"); 
		} 
	} 
} 
