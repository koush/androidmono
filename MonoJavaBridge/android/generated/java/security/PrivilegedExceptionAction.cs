namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PrivilegedExceptionAction_))]
	public partial interface PrivilegedExceptionAction  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PrivilegedExceptionAction))]
	internal sealed partial class PrivilegedExceptionAction_ : java.lang.Object, PrivilegedExceptionAction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PrivilegedExceptionAction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.security.PrivilegedExceptionAction.run()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.PrivilegedExceptionAction_.staticClass, "run", "()Ljava/lang/Object;", ref global::java.security.PrivilegedExceptionAction_._m0) as java.lang.Object;
		}
		static PrivilegedExceptionAction_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivilegedExceptionAction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivilegedExceptionAction"));
		}
	}
}
