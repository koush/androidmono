namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstantiationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstantiationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationException20193;
		public InstantiationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationException.staticClass, global::java.lang.InstantiationException._InstantiationException20193);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstantiationException20194;
		public InstantiationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InstantiationException.staticClass, global::java.lang.InstantiationException._InstantiationException20194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InstantiationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InstantiationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InstantiationException"));
			global::java.lang.InstantiationException._InstantiationException20193 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationException.staticClass, "<init>", "()V");
			global::java.lang.InstantiationException._InstantiationException20194 = @__env.GetMethodIDNoThrow(global::java.lang.InstantiationException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
