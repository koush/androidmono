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
		internal static global::MonoJavaBridge.MethodId _getInstance13391;
		public static global::android.text.method.SingleLineTransformationMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getInstance13391)) as android.text.method.SingleLineTransformationMethod;
		}
		protected new char[] Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13392;
		protected override char[] getOriginal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod._getOriginal13392)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getOriginal13392)) as char[];
		}
		protected new char[] Replacement
		{
			get
			{
				return getReplacement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement13393;
		protected override char[] getReplacement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod._getReplacement13393)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getReplacement13393)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _SingleLineTransformationMethod13394;
		public SingleLineTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._SingleLineTransformationMethod13394);
			Init(@__env, handle);
		}
		static SingleLineTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.SingleLineTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/SingleLineTransformationMethod"));
			global::android.text.method.SingleLineTransformationMethod._getInstance13391 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/SingleLineTransformationMethod;");
			global::android.text.method.SingleLineTransformationMethod._getOriginal13392 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getOriginal", "()[C");
			global::android.text.method.SingleLineTransformationMethod._getReplacement13393 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getReplacement", "()[C");
			global::android.text.method.SingleLineTransformationMethod._SingleLineTransformationMethod13394 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
