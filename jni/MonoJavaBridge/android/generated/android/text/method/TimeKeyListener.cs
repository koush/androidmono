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
		internal static global::MonoJavaBridge.MethodId _getInstance13352;
		public static global::android.text.method.TimeKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInstance13352)) as android.text.method.TimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13353;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.TimeKeyListener._getInputType13353);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInputType13353);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13354;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.TimeKeyListener._getAcceptedChars13354)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getAcceptedChars13354)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeKeyListener13355;
		public TimeKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._TimeKeyListener13355);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13356;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.TimeKeyListener.staticClass, _CHARACTERS13356)) as char[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TimeKeyListener"));
			global::android.text.method.TimeKeyListener._getInstance13352 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;");
			global::android.text.method.TimeKeyListener._getInputType13353 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TimeKeyListener._getAcceptedChars13354 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.TimeKeyListener._TimeKeyListener13355 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.TimeKeyListener._CHARACTERS13356 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
