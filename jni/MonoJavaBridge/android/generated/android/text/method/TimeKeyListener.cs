namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeKeyListener()
		{
			InitJNI();
		}
		protected TimeKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.TimeKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8735;
		public static global::android.text.method.TimeKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInstance8735)) as android.text.method.TimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8736;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.TimeKeyListener._getInputType8736);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInputType8736);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars8737;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.TimeKeyListener._getAcceptedChars8737)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getAcceptedChars8737)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeKeyListener8738;
		public TimeKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._TimeKeyListener8738);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS8739;
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
			global::android.text.method.TimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TimeKeyListener"));
			global::android.text.method.TimeKeyListener._getInstance8735 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;");
			global::android.text.method.TimeKeyListener._getInputType8736 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TimeKeyListener._getAcceptedChars8737 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.TimeKeyListener._TimeKeyListener8738 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V");
		}
	}
}
