namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GenericSignatureFormatError : java.lang.ClassFormatError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GenericSignatureFormatError()
		{
			InitJNI();
		}
		protected GenericSignatureFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _GenericSignatureFormatError20964;
		public GenericSignatureFormatError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.GenericSignatureFormatError.staticClass, global::java.lang.reflect.GenericSignatureFormatError._GenericSignatureFormatError20964);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericSignatureFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericSignatureFormatError"));
			global::java.lang.reflect.GenericSignatureFormatError._GenericSignatureFormatError20964 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.GenericSignatureFormatError.staticClass, "<init>", "()V");
		}
	}
}
