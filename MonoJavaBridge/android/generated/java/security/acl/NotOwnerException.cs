namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotOwnerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotOwnerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotOwnerException23461;
		public NotOwnerException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.NotOwnerException._NotOwnerException23461.native == global::System.IntPtr.Zero)
				global::java.security.acl.NotOwnerException._NotOwnerException23461 = @__env.GetMethodIDNoThrow(global::java.security.acl.NotOwnerException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.NotOwnerException.staticClass, global::java.security.acl.NotOwnerException._NotOwnerException23461);
			Init(@__env, handle);
		}
		static NotOwnerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.NotOwnerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/NotOwnerException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
