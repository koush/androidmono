namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SingleLineTransformationMethod : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SingleLineTransformationMethod()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance8712;
		public static global::android.text.method.SingleLineTransformationMethod getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getInstance8712)) as android.text.method.SingleLineTransformationMethod;
		}
		protected new char[] Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal8713;
		protected override char[] getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod._getOriginal8713)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getOriginal8713)) as char[];
		}
		protected new char[] Replacement
		{
			get
			{
				return getReplacement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement8714;
		protected override char[] getReplacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod._getReplacement8714)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._getReplacement8714)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _SingleLineTransformationMethod8715;
		public SingleLineTransformationMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.SingleLineTransformationMethod.staticClass, global::android.text.method.SingleLineTransformationMethod._SingleLineTransformationMethod8715);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.SingleLineTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/SingleLineTransformationMethod"));
			global::android.text.method.SingleLineTransformationMethod._getInstance8712 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/SingleLineTransformationMethod;");
			global::android.text.method.SingleLineTransformationMethod._getOriginal8713 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getOriginal", "()[C");
			global::android.text.method.SingleLineTransformationMethod._getReplacement8714 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "getReplacement", "()[C");
			global::android.text.method.SingleLineTransformationMethod._SingleLineTransformationMethod8715 = @__env.GetMethodIDNoThrow(global::android.text.method.SingleLineTransformationMethod.staticClass, "<init>", "()V");
		}
	}
}
