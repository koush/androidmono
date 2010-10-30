namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrivilegedActionException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrivilegedActionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause23248;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.PrivilegedActionException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.security.PrivilegedActionException._getCause23248) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString23249;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PrivilegedActionException.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.PrivilegedActionException._toString23249) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException23250;
		public virtual global::java.lang.Exception getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.PrivilegedActionException.staticClass, "getException", "()Ljava/lang/Exception;", ref global::java.security.PrivilegedActionException._getException23250) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _PrivilegedActionException23251;
		public PrivilegedActionException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PrivilegedActionException._PrivilegedActionException23251.native == global::System.IntPtr.Zero)
				global::java.security.PrivilegedActionException._PrivilegedActionException23251 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PrivilegedActionException.staticClass, global::java.security.PrivilegedActionException._PrivilegedActionException23251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PrivilegedActionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivilegedActionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivilegedActionException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
