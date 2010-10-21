namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AclNotFoundException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AclNotFoundException()
		{
			InitJNI();
		}
		protected AclNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AclNotFoundException23332;
		public AclNotFoundException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.AclNotFoundException.staticClass, global::java.security.acl.AclNotFoundException._AclNotFoundException23332);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclNotFoundException"));
			global::java.security.acl.AclNotFoundException._AclNotFoundException23332 = @__env.GetMethodIDNoThrow(global::java.security.acl.AclNotFoundException.staticClass, "<init>", "()V");
		}
	}
}
