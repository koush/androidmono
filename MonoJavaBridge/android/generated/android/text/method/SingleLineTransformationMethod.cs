namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SingleLineTransformationMethod : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SingleLineTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.SingleLineTransformationMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.SingleLineTransformationMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.SingleLineTransformationMethod._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.SingleLineTransformationMethod._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/SingleLineTransformationMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._m0)) as android.text.method.SingleLineTransformationMethod;
		}
		protected new char[] Original
		{
			get
			{
				return getOriginal();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override char[] getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.SingleLineTransformationMethod.staticClass, "getOriginal", "()[C", ref global::android.text.method.SingleLineTransformationMethod._m1) as char[];
		}
		protected new char[] Replacement
		{
			get
			{
				return getReplacement();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override char[] getReplacement()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.SingleLineTransformationMethod.staticClass, "getReplacement", "()[C", ref global::android.text.method.SingleLineTransformationMethod._m2) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SingleLineTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.SingleLineTransformationMethod._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.SingleLineTransformationMethod._m3 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._m3);
			Init(@__env, handle);
		}
		static SingleLineTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.SingleLineTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/SingleLineTransformationMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
