namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getInstance13414;
		public static global::android.text.method.TimeKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInstance13414)) as android.text.method.TimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13415;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getInputType13415);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13416;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._getAcceptedChars13416)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeKeyListener13417;
		public TimeKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._TimeKeyListener13417);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13418;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.TimeKeyListener.staticClass, _CHARACTERS13418)) as char[];
			}
		}
		static TimeKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TimeKeyListener"));
			global::android.text.method.TimeKeyListener._getInstance13414 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;");
			global::android.text.method.TimeKeyListener._getInputType13415 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TimeKeyListener._getAcceptedChars13416 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.TimeKeyListener._TimeKeyListener13417 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.TimeKeyListener._CHARACTERS13418 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
		internal static void InitJNI()
		{
		}
	}
}
