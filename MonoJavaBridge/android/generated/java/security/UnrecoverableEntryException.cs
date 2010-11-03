namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnrecoverableEntryException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnrecoverableEntryException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnrecoverableEntryException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableEntryException._m0.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableEntryException._m0 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableEntryException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableEntryException.staticClass, global::java.security.UnrecoverableEntryException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnrecoverableEntryException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.UnrecoverableEntryException._m1.native == global::System.IntPtr.Zero)
				global::java.security.UnrecoverableEntryException._m1 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableEntryException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableEntryException.staticClass, global::java.security.UnrecoverableEntryException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnrecoverableEntryException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnrecoverableEntryException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnrecoverableEntryException"));
		}
	}
}
