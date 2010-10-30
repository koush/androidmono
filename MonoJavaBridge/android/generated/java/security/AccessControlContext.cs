namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessControlContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessControlContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22828;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._equals22828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22829;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._hashCode22829);
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission22830;
		public void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._checkPermission22830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.DomainCombiner DomainCombiner
		{
			get
			{
				return getDomainCombiner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomainCombiner22831;
		public global::java.security.DomainCombiner getDomainCombiner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.DomainCombiner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._getDomainCombiner22831)) as java.security.DomainCombiner;
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlContext22832;
		public AccessControlContext(java.security.ProtectionDomain[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._AccessControlContext22832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccessControlContext22833;
		public AccessControlContext(java.security.AccessControlContext arg0, java.security.DomainCombiner arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AccessControlContext.staticClass, global::java.security.AccessControlContext._AccessControlContext22833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccessControlContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AccessControlContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AccessControlContext"));
			global::java.security.AccessControlContext._equals22828 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.AccessControlContext._hashCode22829 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "hashCode", "()I");
			global::java.security.AccessControlContext._checkPermission22830 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.security.AccessControlContext._getDomainCombiner22831 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "getDomainCombiner", "()Ljava/security/DomainCombiner;");
			global::java.security.AccessControlContext._AccessControlContext22832 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "([Ljava/security/ProtectionDomain;)V");
			global::java.security.AccessControlContext._AccessControlContext22833 = @__env.GetMethodIDNoThrow(global::java.security.AccessControlContext.staticClass, "<init>", "(Ljava/security/AccessControlContext;Ljava/security/DomainCombiner;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
