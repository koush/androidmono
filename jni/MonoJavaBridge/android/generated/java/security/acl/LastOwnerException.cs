namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LastOwnerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LastOwnerException()
		{
			InitJNI();
		}
		protected LastOwnerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LastOwnerException17740;
		public LastOwnerException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.LastOwnerException.staticClass, global::java.security.acl.LastOwnerException._LastOwnerException17740);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.LastOwnerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/LastOwnerException"));
			global::java.security.acl.LastOwnerException._LastOwnerException17740 = @__env.GetMethodIDNoThrow(global::java.security.acl.LastOwnerException.staticClass, "<init>", "()V");
		}
	}
}
