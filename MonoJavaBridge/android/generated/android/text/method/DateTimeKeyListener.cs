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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.DateTimeKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DateTimeKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.DateTimeKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._m0)) as android.text.method.DateTimeKeyListener;
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DateTimeKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.DateTimeKeyListener._m1);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.DateTimeKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.DateTimeKeyListener._m2) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DateTimeKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DateTimeKeyListener._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.DateTimeKeyListener._m3 = @__env.GetMethodIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DateTimeKeyListener.staticClass, global::android.text.method.DateTimeKeyListener._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS5346;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.DateTimeKeyListener.staticClass, _CHARACTERS5346)) as char[];
			}
		}
		static DateTimeKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DateTimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DateTimeKeyListener"));
			global::android.text.method.DateTimeKeyListener._CHARACTERS5346 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.DateTimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
	}
}
