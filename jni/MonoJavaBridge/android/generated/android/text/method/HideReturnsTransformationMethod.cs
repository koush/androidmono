namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HideReturnsTransformationMethod : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HideReturnsTransformationMethod()
		{
			InitJNI();
		}
		protected HideReturnsTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8071;
		public static global::android.text.method.HideReturnsTransformationMethod getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getInstance8071)) as android.text.method.HideReturnsTransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal8072;
		protected override char[] getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.HideReturnsTransformationMethod._getOriginal8072)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getOriginal8072)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement8073;
		protected override char[] getReplacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.HideReturnsTransformationMethod._getReplacement8073)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getReplacement8073)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _HideReturnsTransformationMethod8074;
		public HideReturnsTransformationMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._HideReturnsTransformationMethod8074);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.HideReturnsTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/HideReturnsTransformationMethod"));
			global::android.text.method.HideReturnsTransformationMethod._getInstance8071 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;");
			global::android.text.method.HideReturnsTransformationMethod._getOriginal8072 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getOriginal", "()[C");
			global::android.text.method.HideReturnsTransformationMethod._getReplacement8073 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getReplacement", "()[C");
			global::android.text.method.HideReturnsTransformationMethod._HideReturnsTransformationMethod8074 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "<init>", "()V");
		}
	}
}
