namespace java.security.spec
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.spec.AlgorithmParameterSpec_))]
	public partial interface AlgorithmParameterSpec  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.AlgorithmParameterSpec))]
	internal sealed partial class AlgorithmParameterSpec_ : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParameterSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AlgorithmParameterSpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.AlgorithmParameterSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/AlgorithmParameterSpec"));
		}
	}
}
