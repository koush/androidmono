namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnrecoverableEntryException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnrecoverableEntryException()
		{
			InitJNI();
		}
		protected UnrecoverableEntryException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableEntryException23414;
		public UnrecoverableEntryException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableEntryException.staticClass, global::java.security.UnrecoverableEntryException._UnrecoverableEntryException23414);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnrecoverableEntryException23415;
		public UnrecoverableEntryException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnrecoverableEntryException.staticClass, global::java.security.UnrecoverableEntryException._UnrecoverableEntryException23415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnrecoverableEntryException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnrecoverableEntryException"));
			global::java.security.UnrecoverableEntryException._UnrecoverableEntryException23414 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableEntryException.staticClass, "<init>", "()V");
			global::java.security.UnrecoverableEntryException._UnrecoverableEntryException23415 = @__env.GetMethodIDNoThrow(global::java.security.UnrecoverableEntryException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
