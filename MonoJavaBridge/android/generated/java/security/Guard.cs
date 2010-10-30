namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Guard_))]
	public partial interface Guard  : global::MonoJavaBridge.IJavaObject 
	{
		void checkGuard(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Guard))]
	internal sealed partial class Guard_ : java.lang.Object, Guard
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Guard_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkGuard22957;
		void java.security.Guard.checkGuard(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Guard_._checkGuard22957.native == global::System.IntPtr.Zero)
				global::java.security.Guard_._checkGuard22957 = @__env.GetMethodIDNoThrow(global::java.security.Guard_.staticClass, "checkGuard", "(Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Guard_._checkGuard22957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Guard_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Guard_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Guard"));
		}
		internal static void InitJNI()
		{
		}
	}
}
