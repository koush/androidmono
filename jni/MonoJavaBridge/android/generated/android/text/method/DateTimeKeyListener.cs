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
		internal static global::MonoJavaBridge.MethodId _getInstance13209;
		public static global::android.text.method.DateTimeKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInstance13209)) as android.text.method.DateTimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13210;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener._getInputType13210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getInputType13210);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13211;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener._getAcceptedChars13211)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._getAcceptedChars13211)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateTimeKeyListener13212;
		public DateTimeKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._DateTimeKeyListener13212);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13213;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DateTimeKeyListener.staticClass, _CHARACTERS13213)) as char[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DateTimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateTimeKeyListener"));
			global::android.text.method.DateTimeKeyListener._getInstance13209 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
			global::android.text.method.DateTimeKeyListener._getInputType13210 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateTimeKeyListener._getAcceptedChars13211 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateTimeKeyListener._DateTimeKeyListener13212 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DateTimeKeyListener._CHARACTERS13213 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
