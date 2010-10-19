namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateTimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateTimeKeyListener()
		{
			InitJNI();
		}
		protected DateTimeKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.DateTimeKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8598;
		public static global::android.text.method.DateTimeKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInstance8598)) as android.text.method.DateTimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8599;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener._getInputType8599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInputType8599);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars8600;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener._getAcceptedChars8600)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getAcceptedChars8600)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateTimeKeyListener8601;
		public DateTimeKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._DateTimeKeyListener8601);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS8602;
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
			global::android.text.method.DateTimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateTimeKeyListener"));
			global::android.text.method.DateTimeKeyListener._getInstance8598 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
			global::android.text.method.DateTimeKeyListener._getInputType8599 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateTimeKeyListener._getAcceptedChars8600 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateTimeKeyListener._DateTimeKeyListener8601 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V");
		}
	}
}
