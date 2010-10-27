namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnrecoverableKeyException : java.security.UnrecoverableEntryException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnrecoverableKeyException()
		{
			InitJNI();
		}
		protected UnrecoverableKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableKeyException23416;
		public UnrecoverableKeyException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23416);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableKeyException23417;
		public UnrecoverableKeyException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnrecoverableKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnrecoverableKeyException"));
			global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23416 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "()V");
			global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23417 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
