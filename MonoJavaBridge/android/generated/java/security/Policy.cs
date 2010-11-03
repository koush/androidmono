namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Policy_))]
	public abstract partial class Policy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Policy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", ref global::java.security.Policy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.ProtectionDomain arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", ref global::java.security.Policy._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool implies(java.security.ProtectionDomain arg0, java.security.Permission arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Policy.staticClass, "implies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z", ref global::java.security.Policy._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Policy.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.Policy._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.Policy._m4) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void refresh()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Policy.staticClass, "refresh", "()V", ref global::java.security.Policy._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.security.Policy getPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._m6.native == global::System.IntPtr.Zero)
				global::java.security.Policy._m6 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "getPolicy", "()Ljava/security/Policy;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Policy.staticClass, global::java.security.Policy._m6)) as java.security.Policy;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void setPolicy(java.security.Policy arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._m7.native == global::System.IntPtr.Zero)
				global::java.security.Policy._m7 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "setPolicy", "(Ljava/security/Policy;)V");
			@__env.CallStaticVoidMethod(java.security.Policy.staticClass, global::java.security.Policy._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Policy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._m8.native == global::System.IntPtr.Zero)
				global::java.security.Policy._m8 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Policy.staticClass, global::java.security.Policy._m8);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNSUPPORTED_EMPTY_COLLECTION6525;
		public static global::java.security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.Policy.staticClass, _UNSUPPORTED_EMPTY_COLLECTION6525)) as java.security.PermissionCollection;
			}
		}
		static Policy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Policy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Policy"));
			global::java.security.Policy._UNSUPPORTED_EMPTY_COLLECTION6525 = @__env.GetStaticFieldIDNoThrow(global::java.security.Policy.staticClass, "UNSUPPORTED_EMPTY_COLLECTION", "Ljava/security/PermissionCollection;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Policy))]
	internal sealed partial class Policy_ : java.security.Policy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Policy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Policy_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Policy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Policy"));
		}
	}
}
