namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DialerKeyListener : android.text.method.NumberKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DialerKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.DialerKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.DialerKeyListener(@__env); 
			} 
		} 
		protected DialerKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7138; 
		public static global::android.text.method.DialerKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DialerKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInstance7138)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lookup7139; 
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return @__env.CallIntMethod(this, global::android.text.method.DialerKeyListener._lookup7139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._lookup7139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7140; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return @__env.CallIntMethod(this, global::android.text.method.DialerKeyListener._getInputType7140); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInputType7140); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7141; 
		protected override char[] getAcceptedChars() 
		{ 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DialerKeyListener._getAcceptedChars7141)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getAcceptedChars7141)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialerKeyListener7142; 
		public DialerKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._DialerKeyListener7142, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7143; 
		public static char[] CHARACTERS
		{ 
			get 
			{ 
				return default(char[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.DialerKeyListener.staticClass = @__class; 
			global::android.text.method.DialerKeyListener._getInstance7138 = @__env.GetStaticMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;"); 
			global::android.text.method.DialerKeyListener._lookup7139 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I"); 
			global::android.text.method.DialerKeyListener._getInputType7140 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.DialerKeyListener._getAcceptedChars7141 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C"); 
			global::android.text.method.DialerKeyListener._DialerKeyListener7142 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
