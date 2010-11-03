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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.ECGenParameterSpec.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.spec.ECGenParameterSpec._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ECGenParameterSpec(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECGenParameterSpec._m1.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECGenParameterSpec._m1 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECGenParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECGenParameterSpec.staticClass, global::java.security.spec.ECGenParameterSpec._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ECGenParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECGenParameterSpec"));
		}
	}
}
