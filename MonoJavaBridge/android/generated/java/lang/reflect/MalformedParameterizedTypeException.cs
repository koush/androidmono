namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedParameterizedTypeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedParameterizedTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedParameterizedTypeException21090;
		public MalformedParameterizedTypeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.MalformedParameterizedTypeException.staticClass, global::java.lang.reflect.MalformedParameterizedTypeException._MalformedParameterizedTypeException21090);
			Init(@__env, handle);
		}
		static MalformedParameterizedTypeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.MalformedParameterizedTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/MalformedParameterizedTypeException"));
			global::java.lang.reflect.MalformedParameterizedTypeException._MalformedParameterizedTypeException21090 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.MalformedParameterizedTypeException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}