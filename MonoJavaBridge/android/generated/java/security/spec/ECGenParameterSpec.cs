namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECGenParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECGenParameterSpec.staticClass, global::java.security.spec.ECGenParameterSpec._getName23993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ECGenParameterSpec23994;
		public ECGenParameterSpec(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECGenParameterSpec.staticClass, global::java.security.spec.ECGenParameterSpec._ECGenParameterSpec23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ECGenParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECGenParameterSpec"));
			global::java.security.spec.ECGenParameterSpec._getName23993 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECGenParameterSpec.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.spec.ECGenParameterSpec._ECGenParameterSpec23994 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECGenParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
