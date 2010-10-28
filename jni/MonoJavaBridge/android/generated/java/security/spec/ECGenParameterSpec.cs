namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECGenParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECGenParameterSpec()
		{
			InitJNI();
		}
		protected ECGenParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName23993;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECGenParameterSpec._getName23993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECGenParameterSpec.staticClass, global::java.security.spec.ECGenParameterSpec._getName23993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ECGenParameterSpec23994;
		public ECGenParameterSpec(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECGenParameterSpec.staticClass, global::java.security.spec.ECGenParameterSpec._ECGenParameterSpec23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECGenParameterSpec"));
			global::java.security.spec.ECGenParameterSpec._getName23993 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECGenParameterSpec.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.spec.ECGenParameterSpec._ECGenParameterSpec23994 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECGenParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
