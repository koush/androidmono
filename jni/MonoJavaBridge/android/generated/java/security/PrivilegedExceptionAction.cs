namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PrivilegedExceptionAction_))]
	public partial interface PrivilegedExceptionAction  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PrivilegedExceptionAction))]
	public sealed partial class PrivilegedExceptionAction_ : java.lang.Object, PrivilegedExceptionAction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrivilegedExceptionAction_()
		{
			InitJNI();
		}
		internal PrivilegedExceptionAction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run23133;
		 global::java.lang.Object java.security.PrivilegedExceptionAction.run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivilegedExceptionAction_._run23133)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivilegedExceptionAction_.staticClass, global::java.security.PrivilegedExceptionAction_._run23133)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivilegedExceptionAction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivilegedExceptionAction"));
			global::java.security.PrivilegedExceptionAction_._run23133 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedExceptionAction_.staticClass, "run", "()Ljava/lang/Object;");
		}
	}
}
