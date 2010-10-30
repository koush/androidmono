namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PrivilegedAction_))]
	public partial interface PrivilegedAction  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PrivilegedAction))]
	internal sealed partial class PrivilegedAction_ : java.lang.Object, PrivilegedAction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PrivilegedAction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run23247;
		global::java.lang.Object java.security.PrivilegedAction.run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PrivilegedAction_._run23247.native == global::System.IntPtr.Zero)
				global::java.security.PrivilegedAction_._run23247 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedAction_.staticClass, "run", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivilegedAction_._run23247)) as java.lang.Object;
		}
		static PrivilegedAction_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivilegedAction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivilegedAction"));
		}
		internal static void InitJNI()
		{
		}
	}
}
