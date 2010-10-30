namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.DateKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13266;
		public static global::android.text.method.DateKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DateKeyListener._getInstance13266.native == global::System.IntPtr.Zero)
				global::android.text.method.DateKeyListener._getInstance13266 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInstance13266)) as android.text.method.DateKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13267;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DateKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.DateKeyListener._getInputType13267);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13268;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.DateKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.DateKeyListener._getAcceptedChars13268) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateKeyListener13269;
		public DateKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DateKeyListener._DateKeyListener13269.native == global::System.IntPtr.Zero)
				global::android.text.method.DateKeyListener._DateKeyListener13269 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._DateKeyListener13269);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13270;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DateKeyListener.staticClass, _CHARACTERS13270)) as char[];
			}
		}
		static DateKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DateKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateKeyListener"));
			global::android.text.method.DateKeyListener._CHARACTERS13270 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "CHARACTERS", "[C");
		}
		internal static void InitJNI()
		{
		}
	}
}
