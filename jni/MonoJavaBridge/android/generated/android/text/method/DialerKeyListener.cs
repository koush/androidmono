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
		internal static global::MonoJavaBridge.MethodId _getInstance13214;
		public static global::android.text.method.DialerKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInstance13214)) as android.text.method.DialerKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _lookup13215;
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._lookup13215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._lookup13215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13216;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._getInputType13216);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getInputType13216);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13217;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DialerKeyListener._getAcceptedChars13217)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._getAcceptedChars13217)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DialerKeyListener13218;
		public DialerKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DialerKeyListener.staticClass, global::android.text.method.DialerKeyListener._DialerKeyListener13218);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13219;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DialerKeyListener.staticClass, _CHARACTERS13219)) as char[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DialerKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DialerKeyListener"));
			global::android.text.method.DialerKeyListener._getInstance13214 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;");
			global::android.text.method.DialerKeyListener._lookup13215 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I");
			global::android.text.method.DialerKeyListener._getInputType13216 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DialerKeyListener._getAcceptedChars13217 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DialerKeyListener._DialerKeyListener13218 = @__env.GetMethodIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DialerKeyListener._CHARACTERS13219 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DialerKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
