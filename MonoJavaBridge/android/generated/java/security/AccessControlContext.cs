namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessControlContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessControlContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.AccessControlContext.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.AccessControlContext._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.AccessControlContext.staticClass, "hashCode", "()I", ref global::java.security.AccessControlContext._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AccessControlContext.staticClass, "checkPermission", "(Ljava/security/Permission;)V", ref global::java.security.AccessControlContext._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.DomainCombiner DomainCombiner
		{
			get
			{
				return getDomainCombiner();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.security.DomainCombiner getDomainCombiner()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.DomainCombiner>(this, global::java.security.AccessControlContext.staticClass, "getDomainCombiner", "()Ljava/security/DomainCombiner;", ref global::java.security.AccessControlContext._m3) as java.security.DomainCombiner;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public AccessControlContext(java.security.ProtectionDomain[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessControlContext._m4.native == global::System.IntPtr.Zero)
				global::java.security.AccessControlContext._m4 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "([Ljava/security/ProtectionDomain;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AccessControlContext(java.security.AccessControlContext arg0, java.security.DomainCombiner arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AccessControlContext._m5.native == global::System.IntPtr.Zero)
				global::java.security.AccessControlContext._m5 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "(Ljava/security/AccessControlContext;Ljava/security/DomainCombiner;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccessControlContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessControlContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessControlContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
