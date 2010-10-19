namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DialerKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialerKeyListener()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance8603;
		public static global::android.text.method.DialerKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInstance8603)) as android.text.method.DialerKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _lookup8604;
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._lookup8604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._lookup8604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8605;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._getInputType8605);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInputType8605);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars8606;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._getAcceptedChars8606)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getAcceptedChars8606)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DialerKeyListener8607;
		public DialerKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._DialerKeyListener8607);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS8608;
		public static char[] CHARACTERS
		{
			get
			{
				return default(char[]);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DialerKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DialerKeyListener"));
			global::android.text.method.DialerKeyListener._getInstance8603 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;");
			global::android.text.method.DialerKeyListener._lookup8604 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I");
			global::android.text.method.DialerKeyListener._getInputType8605 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DialerKeyListener._getAcceptedChars8606 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DialerKeyListener._DialerKeyListener8607 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V");
		}
	}
}
