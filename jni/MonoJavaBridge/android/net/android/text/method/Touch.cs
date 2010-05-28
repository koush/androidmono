namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Touch : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Touch() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.Touch), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.Touch(@__env); 
			} 
		} 
		protected Touch(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent7271; 
		public static bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._onTouchEvent7271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo7272; 
		public static void scrollTo(android.widget.TextView arg0, android.text.Layout arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._scrollTo7272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInitialScrollX7273; 
		public static int getInitialScrollX(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._getInitialScrollX7273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInitialScrollY7274; 
		public static int getInitialScrollY(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._getInitialScrollY7274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.Touch.staticClass = @__class; 
			global::android.text.method.Touch._onTouchEvent7271 = @__env.GetStaticMethodID(global::android.text.method.Touch.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z"); 
			global::android.text.method.Touch._scrollTo7272 = @__env.GetStaticMethodID(global::android.text.method.Touch.staticClass, "scrollTo", "(Landroid/widget/TextView;Landroid/text/Layout;II)V"); 
			global::android.text.method.Touch._getInitialScrollX7273 = @__env.GetStaticMethodID(global::android.text.method.Touch.staticClass, "getInitialScrollX", "(Landroid/widget/TextView;Landroid/text/Spannable;)I"); 
			global::android.text.method.Touch._getInitialScrollY7274 = @__env.GetStaticMethodID(global::android.text.method.Touch.staticClass, "getInitialScrollY", "(Landroid/widget/TextView;Landroid/text/Spannable;)I"); 
		} 
	} 
} 
