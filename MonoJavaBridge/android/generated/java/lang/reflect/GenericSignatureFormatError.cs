namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GenericSignatureFormatError : java.lang.ClassFormatError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GenericSignatureFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public GenericSignatureFormatError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.GenericSignatureFormatError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.GenericSignatureFormatError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.GenericSignatureFormatError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.GenericSignatureFormatError.staticClass, global::java.lang.reflect.GenericSignatureFormatError._m0);
			Init(@__env, handle);
		}
		static GenericSignatureFormatError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.GenericSignatureFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/GenericSignatureFormatError"));
		}
	}
}
