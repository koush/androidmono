namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessController : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessController()
		{
			InitJNI();
		}
		internal AccessController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission22718;
		public static void checkPermission(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.AccessController.staticClass, global::java.security.AccessController._checkPermission22718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22719;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22720;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0, java.security.AccessControlContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22721;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22722;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0, java.security.AccessControlContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public static global::java.security.AccessControlContext Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext22723;
		public static global::java.security.AccessControlContext getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.AccessControlContext>(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._getContext22723)) as java.security.AccessControlContext;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivilegedWithCombiner22724;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivilegedWithCombiner22724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivilegedWithCombiner22725;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedExceptionAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivilegedWithCombiner22725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessController.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessController"));
			global::java.security.AccessController._checkPermission22718 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.security.AccessController._doPrivileged22719 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22720 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22721 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22722 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::java.security.AccessController._getContext22723 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "getContext", "()Ljava/security/AccessControlContext;");
			global::java.security.AccessController._doPrivilegedWithCombiner22724 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivilegedWithCombiner22725 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
		}
	}
}
