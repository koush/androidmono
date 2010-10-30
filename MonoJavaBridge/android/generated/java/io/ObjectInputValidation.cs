namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectInputValidation_))]
	public partial interface ObjectInputValidation  : global::MonoJavaBridge.IJavaObject 
	{
		void validateObject();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputValidation))]
	internal sealed partial class ObjectInputValidation_ : java.lang.Object, ObjectInputValidation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ObjectInputValidation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _validateObject19223;
		void java.io.ObjectInputValidation.validateObject()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputValidation_.staticClass, "validateObject", "()V", ref global::java.io.ObjectInputValidation_._validateObject19223);
		}
		static ObjectInputValidation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputValidation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputValidation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
