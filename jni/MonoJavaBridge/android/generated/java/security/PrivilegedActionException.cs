namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrivilegedActionException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrivilegedActionException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause23247;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException._getCause23247)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException.staticClass, global::java.security.PrivilegedActionException._getCause23247)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString23248;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException._toString23248)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException.staticClass, global::java.security.PrivilegedActionException._toString23248)) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException23249;
		public virtual global::java.lang.Exception getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException._getException23249)) as java.lang.Exception;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivilegedActionException.staticClass, global::java.security.PrivilegedActionException._getException23249)) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _PrivilegedActionException23250;
		public PrivilegedActionException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PrivilegedActionException.staticClass, global::java.security.PrivilegedActionException._PrivilegedActionException23250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivilegedActionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivilegedActionException"));
			global::java.security.PrivilegedActionException._getCause23247 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedActionException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.security.PrivilegedActionException._toString23248 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedActionException.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.PrivilegedActionException._getException23249 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedActionException.staticClass, "getException", "()Ljava/lang/Exception;");
			global::java.security.PrivilegedActionException._PrivilegedActionException23250 = @__env.GetMethodIDNoThrow(global::java.security.PrivilegedActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
