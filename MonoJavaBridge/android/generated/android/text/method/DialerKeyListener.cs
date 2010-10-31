namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DialerKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialerKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.DialerKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.DialerKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DialerKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.DialerKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._m0)) as android.text.method.DialerKeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", ref global::android.text.method.DialerKeyListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.DialerKeyListener._m2);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.DialerKeyListener._m3) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DialerKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DialerKeyListener._m4.native == global::System.IntPtr.Zero)
				global::android.text.method.DialerKeyListener._m4 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._m4);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS5347;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DialerKeyListener.staticClass, _CHARACTERS5347)) as char[];
			}
		}
		static DialerKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DialerKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DialerKeyListener"));
			global::android.text.method.DialerKeyListener._CHARACTERS5347 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
