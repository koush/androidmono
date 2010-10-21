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
		public static global::android.text.method.DateKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13204;
		public static global::android.text.method.DateKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInstance13204)) as android.text.method.DateKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13205;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.DateKeyListener._getInputType13205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getInputType13205);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedChars13206;
		protected override char[] getAcceptedChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.DateKeyListener._getAcceptedChars13206)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._getAcceptedChars13206)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateKeyListener13207;
		public DateKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateKeyListener.staticClass, global::android.text.method.DateKeyListener._DateKeyListener13207);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS13208;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DateKeyListener.staticClass, _CHARACTERS13208)) as char[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DateKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateKeyListener"));
			global::android.text.method.DateKeyListener._getInstance13204 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateKeyListener;");
			global::android.text.method.DateKeyListener._getInputType13205 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DateKeyListener._getAcceptedChars13206 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DateKeyListener._DateKeyListener13207 = @__env.GetMethodIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DateKeyListener._CHARACTERS13208 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DateKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
