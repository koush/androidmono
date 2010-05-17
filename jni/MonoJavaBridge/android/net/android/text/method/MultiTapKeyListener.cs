namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MultiTapKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MultiTapKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.MultiTapKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.MultiTapKeyListener(@__env); 
			} 
		} 
		protected MultiTapKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6831; 
		public static android.text.method.MultiTapKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.MultiTapKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.MultiTapKeyListener.staticClass, _getInstance6831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6832; 
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MultiTapKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.MultiTapKeyListener.staticClass, _onKeyDown6832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6833; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MultiTapKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6833); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.MultiTapKeyListener.staticClass, _getInputType6833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanAdded6834; 
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MultiTapKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanAdded6834, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.MultiTapKeyListener.staticClass, _onSpanAdded6834, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanRemoved6835; 
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MultiTapKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanRemoved6835, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.MultiTapKeyListener.staticClass, _onSpanRemoved6835, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanChanged6836; 
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MultiTapKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanChanged6836, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.MultiTapKeyListener.staticClass, _onSpanChanged6836, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiTapKeyListener6837; 
		public MultiTapKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.MultiTapKeyListener.staticClass, _MultiTapKeyListener6837, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.MultiTapKeyListener.staticClass = @__class; 
			global::android.text.method.MultiTapKeyListener._getInstance6831 = @__env.GetStaticMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/MultiTapKeyListener;"); 
			global::android.text.method.MultiTapKeyListener._onKeyDown6832 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.MultiTapKeyListener._getInputType6833 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.MultiTapKeyListener._onSpanAdded6834 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.method.MultiTapKeyListener._onSpanRemoved6835 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.method.MultiTapKeyListener._onSpanChanged6836 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V"); 
			global::android.text.method.MultiTapKeyListener._MultiTapKeyListener6837 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V"); 
		} 
	} 
} 
