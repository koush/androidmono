namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GenericSignatureFormatError : java.lang.ClassFormatError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GenericSignatureFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _GenericSignatureFormatError21083;
		public GenericSignatureFormatError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.GenericSignatureFormatError.staticClass, global::java.lang.reflect.GenericSignatureFormatError._GenericSignatureFormatError21083);
			Init(@__env, handle);
		}
		static GenericSignatureFormatError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericSignatureFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericSignatureFormatError"));
			global::java.lang.reflect.GenericSignatureFormatError._GenericSignatureFormatError21083 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.GenericSignatureFormatError.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
