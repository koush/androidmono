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
		internal static global::MonoJavaBridge.MethodId _getInstance13276;
		public static global::android.text.method.DialerKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DialerKeyListener._getInstance13276.native == global::System.IntPtr.Zero)
				global::android.text.method.DialerKeyListener._getInstance13276 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInstance13276)) as android.text.method.DialerKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _lookup13277;
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", ref global::android.text.method.DialerKeyListener._lookup13277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13278;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.DialerKeyListener._getInputType13278);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13279;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.DialerKeyListener._getAcceptedChars13279) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DialerKeyListener13280;
		public DialerKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DialerKeyListener._DialerKeyListener13280.native == global::System.IntPtr.Zero)
				global::android.text.method.DialerKeyListener._DialerKeyListener13280 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._DialerKeyListener13280);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13281;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DialerKeyListener.staticClass, _CHARACTERS13281)) as char[];
			}
		}
		static DialerKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DialerKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DialerKeyListener"));
			global::android.text.method.DialerKeyListener._CHARACTERS13281 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "CHARACTERS", "[C");
		}
		internal static void InitJNI()
		{
		}
	}
}
