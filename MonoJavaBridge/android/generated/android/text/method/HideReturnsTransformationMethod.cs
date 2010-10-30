namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HideReturnsTransformationMethod : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HideReturnsTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.HideReturnsTransformationMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.HideReturnsTransformationMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.HideReturnsTransformationMethod._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.HideReturnsTransformationMethod._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._m0)) as android.text.method.HideReturnsTransformationMethod;
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
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.HideReturnsTransformationMethod.staticClass, "getOriginal", "()[C", ref global::android.text.method.HideReturnsTransformationMethod._m1) as char[];
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
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.text.method.HideReturnsTransformationMethod.staticClass, "getReplacement", "()[C", ref global::android.text.method.HideReturnsTransformationMethod._m2) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public HideReturnsTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.HideReturnsTransformationMethod._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.HideReturnsTransformationMethod._m3 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._m3);
			Init(@__env, handle);
		}
		static HideReturnsTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.HideReturnsTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/HideReturnsTransformationMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
