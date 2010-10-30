namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigitsKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigitsKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.DigitsKeyListener getInstance(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DigitsKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.DigitsKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(ZZ)Landroid/text/method/DigitsKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.DigitsKeyListener;
		}
		public static global::android.text.method.DigitsKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.method.DigitsKeyListener getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DigitsKeyListener._m1.native == global::System.IntPtr.Zero)
				global::android.text.method.DigitsKeyListener._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "()Landroid/text/method/DigitsKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._m1)) as android.text.method.DigitsKeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.text.method.DigitsKeyListener getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DigitsKeyListener._m2.native == global::System.IntPtr.Zero)
				global::android.text.method.DigitsKeyListener._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.method.DigitsKeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.method.DigitsKeyListener.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", ref global::android.text.method.DigitsKeyListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.DigitsKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.DigitsKeyListener._m4);
		}
		protected new char[] AcceptedChars
		{
			get
			{
				return getAcceptedChars();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override char[] getAcceptedChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.DigitsKeyListener.staticClass, "getAcceptedChars", "()[C", ref global::android.text.method.DigitsKeyListener._m5) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DigitsKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DigitsKeyListener._m6.native == global::System.IntPtr.Zero)
				global::android.text.method.DigitsKeyListener._m6 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._m6);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public DigitsKeyListener(bool arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.DigitsKeyListener._m7.native == global::System.IntPtr.Zero)
				global::android.text.method.DigitsKeyListener._m7 = @__env.GetMethodIDNoThrow(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "(ZZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DigitsKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.DigitsKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/DigitsKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
