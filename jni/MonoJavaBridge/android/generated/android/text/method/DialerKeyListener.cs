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
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7764;
		public static global::android.text.method.DialerKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DialerKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInstance7764));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lookup7765;
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.DialerKeyListener._lookup7765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._lookup7765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7766;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.DialerKeyListener._getInputType7766);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInputType7766);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7767;
		protected override char[] getAcceptedChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DialerKeyListener._getAcceptedChars7767));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getAcceptedChars7767));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialerKeyListener7768;
		public DialerKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._DialerKeyListener7768, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7769;
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
			global::android.text.method.DialerKeyListener._getInstance7764 = @__env.GetStaticMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;");
			global::android.text.method.DialerKeyListener._lookup7765 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I");
			global::android.text.method.DialerKeyListener._getInputType7766 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DialerKeyListener._getAcceptedChars7767 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DialerKeyListener._DialerKeyListener7768 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V");
		}
	}
}
