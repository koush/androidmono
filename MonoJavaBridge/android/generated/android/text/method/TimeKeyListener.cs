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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.TimeKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TimeKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.TimeKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "getInstance", "()Landroid/text/method/TimeKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._m0)) as android.text.method.TimeKeyListener;
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.TimeKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.TimeKeyListener._m1);
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
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.TimeKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.TimeKeyListener._m2) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public TimeKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.TimeKeyListener._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.TimeKeyListener._m3 = @__env.GetMethodIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TimeKeyListener.staticClass, global::android.text.method.TimeKeyListener._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CHARACTERS5358;
		public static char[] CHARACTERS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetStaticObjectField(global::android.text.method.TimeKeyListener.staticClass, _CHARACTERS5358)) as char[];
			}
		}
		static TimeKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TimeKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TimeKeyListener"));
			global::android.text.method.TimeKeyListener._CHARACTERS5358 = @__env.GetStaticFieldIDNoThrow(global::android.text.method.TimeKeyListener.staticClass, "CHARACTERS", "[C");
		}
		internal static void InitJNI()
		{
		}
	}
}
