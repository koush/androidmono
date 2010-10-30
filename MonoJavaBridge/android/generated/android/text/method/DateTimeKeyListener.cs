namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateTimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getInstance13271;
		public static global::android.text.method.DateTimeKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInstance13271)) as android.text.method.DateTimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13272;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInputType13272);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13273;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getAcceptedChars13273)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateTimeKeyListener13274;
		public DateTimeKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._DateTimeKeyListener13274);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13275;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DateTimeKeyListener.staticClass, _CHARACTERS13275)) as char[];
			}
		}
		static DateTimeKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DateTimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateTimeKeyListener"));
			global::android.text.method.DateTimeKeyListener._getInstance13271 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
			global::android.text.method.DateTimeKeyListener._getInputType13272 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateTimeKeyListener._getAcceptedChars13273 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateTimeKeyListener._DateTimeKeyListener13274 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DateTimeKeyListener._CHARACTERS13275 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
		internal static void InitJNI()
		{
		}
	}
}
