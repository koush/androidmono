namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessController : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m0.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			@__env.CallStaticVoidMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m1.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0, java.security.AccessControlContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m2.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m3.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0, java.security.AccessControlContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m4.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public static global::java.security.AccessControlContext Context
		{
			get
			{
				return getContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.security.AccessControlContext getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m5.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m5 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "getContext", "()Ljava/security/AccessControlContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.AccessControlContext>(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m5)) as java.security.AccessControlContext;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m6.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m6 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessController._m7.native == global::System.IntPtr.Zero)
				global::java.security.AccessController._m7 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static AccessController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessController.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessController"));
		}
	}
}
