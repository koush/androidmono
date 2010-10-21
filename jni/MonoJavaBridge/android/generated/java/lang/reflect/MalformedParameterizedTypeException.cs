namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedParameterizedTypeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MalformedParameterizedTypeException()
		{
			InitJNI();
		}
		protected MalformedParameterizedTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedParameterizedTypeException20971;
		public MalformedParameterizedTypeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.MalformedParameterizedTypeException.staticClass, global::java.lang.reflect.MalformedParameterizedTypeException._MalformedParameterizedTypeException20971);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.MalformedParameterizedTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/MalformedParameterizedTypeException"));
			global::java.lang.reflect.MalformedParameterizedTypeException._MalformedParameterizedTypeException20971 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.MalformedParameterizedTypeException.staticClass, "<init>", "()V");
		}
	}
}
