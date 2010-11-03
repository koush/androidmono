namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccessControlException : java.lang.SecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccessControlException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.Permission Permission
		{
			get
			{
				return getPermission();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.Permission getPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AccessControlException.staticClass, "getPermission", "()Ljava/security/Permission;", ref global::java.security.AccessControlException._m0) as java.security.Permission;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AccessControlException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessControlException._m1.native == global::System.IntPtr.Zero)
				global::java.security.AccessControlException._m1 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlException.staticClass, global::java.security.AccessControlException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AccessControlException(java.lang.String arg0, java.security.Permission arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessControlException._m2.native == global::System.IntPtr.Zero)
				global::java.security.AccessControlException._m2 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlException.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/Permission;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlException.staticClass, global::java.security.AccessControlException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccessControlException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessControlException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessControlException"));
		}
	}
}
