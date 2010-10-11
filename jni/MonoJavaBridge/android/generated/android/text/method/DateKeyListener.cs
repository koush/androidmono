namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateKeyListener()
		{
			InitJNI();
		}
		protected DateKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8047;
		public static global::android.text.method.DateKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInstance8047)) as android.text.method.DateKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8048;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DateKeyListener._getInputType8048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInputType8048);
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars8049;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DateKeyListener._getAcceptedChars8049)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getAcceptedChars8049)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateKeyListener8050;
		public DateKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._DateKeyListener8050);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS8051;
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
			global::android.text.method.DateKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateKeyListener"));
			global::android.text.method.DateKeyListener._getInstance8047 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateKeyListener;");
			global::android.text.method.DateKeyListener._getInputType8048 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateKeyListener._getAcceptedChars8049 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateKeyListener._DateKeyListener8050 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "<init>", "()V");
		}
	}
}
