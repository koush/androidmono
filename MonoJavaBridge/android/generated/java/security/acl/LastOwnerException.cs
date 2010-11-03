namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LastOwnerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LastOwnerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public LastOwnerException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.LastOwnerException._m0.native == global::System.IntPtr.Zero)
				global::java.security.acl.LastOwnerException._m0 = @__env.GetMethodIDNoThrow(global::java.security.acl.LastOwnerException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.LastOwnerException.staticClass, global::java.security.acl.LastOwnerException._m0);
			Init(@__env, handle);
		}
		static LastOwnerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.LastOwnerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/LastOwnerException"));
		}
	}
}
