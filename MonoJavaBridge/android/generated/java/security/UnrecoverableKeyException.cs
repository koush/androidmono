namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnrecoverableKeyException : java.security.UnrecoverableEntryException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnrecoverableKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableKeyException23417;
		public UnrecoverableKeyException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23417.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23417 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23417);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableKeyException23418;
		public UnrecoverableKeyException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23418.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23418 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableKeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableKeyException.staticClass, global::java.security.UnrecoverableKeyException._UnrecoverableKeyException23418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnrecoverableKeyException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnrecoverableKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnrecoverableKeyException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
