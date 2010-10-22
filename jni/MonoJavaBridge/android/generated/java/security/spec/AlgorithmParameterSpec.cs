namespace java.security.spec
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.spec.AlgorithmParameterSpec_))]
	public partial interface AlgorithmParameterSpec  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.AlgorithmParameterSpec))]
	public sealed partial class AlgorithmParameterSpec_ : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlgorithmParameterSpec_()
		{
			InitJNI();
		}
		internal AlgorithmParameterSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.AlgorithmParameterSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/AlgorithmParameterSpec"));
		}
	}
}
