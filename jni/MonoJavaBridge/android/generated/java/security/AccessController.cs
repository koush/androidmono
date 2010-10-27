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
		internal static global::MonoJavaBridge.MethodId _checkPermission22836;
		public static void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.AccessController.staticClass, global::java.security.AccessController._checkPermission22836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22837;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22838;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedAction arg0, java.security.AccessControlContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22839;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivileged22840;
		public static global::java.lang.Object doPrivileged(java.security.PrivilegedExceptionAction arg0, java.security.AccessControlContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivileged22840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public static global::java.security.AccessControlContext Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext22841;
		public static global::java.security.AccessControlContext getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.AccessControlContext>(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._getContext22841)) as java.security.AccessControlContext;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivilegedWithCombiner22842;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivilegedWithCombiner22842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doPrivilegedWithCombiner22843;
		public static global::java.lang.Object doPrivilegedWithCombiner(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AccessController.staticClass, global::java.security.AccessController._doPrivilegedWithCombiner22843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessController.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessController"));
			global::java.security.AccessController._checkPermission22836 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.security.AccessController._doPrivileged22837 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22838 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22839 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivileged22840 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::java.security.AccessController._getContext22841 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "getContext", "()Ljava/security/AccessControlContext;");
			global::java.security.AccessController._doPrivilegedWithCombiner22842 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::java.security.AccessController._doPrivilegedWithCombiner22843 = @__env.GetStaticMethodIDNoThrow(global::java.security.AccessController.staticClass, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
		}
	}
}
