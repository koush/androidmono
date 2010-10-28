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
		internal static global::MonoJavaBridge.MethodId _getPermission22834;
		public virtual global::java.security.Permission getPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AccessControlException._getPermission22834)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AccessControlException.staticClass, global::java.security.AccessControlException._getPermission22834)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlException22835;
		public AccessControlException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlException.staticClass, global::java.security.AccessControlException._AccessControlException22835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlException22836;
		public AccessControlException(java.lang.String arg0, java.security.Permission arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlException.staticClass, global::java.security.AccessControlException._AccessControlException22836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccessControlException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessControlException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessControlException"));
			global::java.security.AccessControlException._getPermission22834 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlException.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.security.AccessControlException._AccessControlException22835 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.AccessControlException._AccessControlException22836 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlException.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/Permission;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
