namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Policy_))]
	public abstract partial class Policy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Policy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23229;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._getPermissions23229.native == global::System.IntPtr.Zero)
				global::java.security.Policy._getPermissions23229 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, global::java.security.Policy._getPermissions23229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23230;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.ProtectionDomain arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._getPermissions23230.native == global::System.IntPtr.Zero)
				global::java.security.Policy._getPermissions23230 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, global::java.security.Policy._getPermissions23230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _implies23231;
		public virtual bool implies(java.security.ProtectionDomain arg0, java.security.Permission arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._implies23231.native == global::System.IntPtr.Zero)
				global::java.security.Policy._implies23231 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "implies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Policy.staticClass, global::java.security.Policy._implies23231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getType23232;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._getType23232.native == global::System.IntPtr.Zero)
				global::java.security.Policy._getType23232 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Policy.staticClass, global::java.security.Policy._getType23232) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23233;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._getProvider23233.native == global::System.IntPtr.Zero)
				global::java.security.Policy._getProvider23233 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getProvider", "()Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Policy.staticClass, global::java.security.Policy._getProvider23233) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _refresh23234;
		public virtual void refresh()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._refresh23234.native == global::System.IntPtr.Zero)
				global::java.security.Policy._refresh23234 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "refresh", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Policy.staticClass, global::java.security.Policy._refresh23234);
		}
		internal static global::MonoJavaBridge.MethodId _getPolicy23235;
		public static global::java.security.Policy getPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._getPolicy23235.native == global::System.IntPtr.Zero)
				global::java.security.Policy._getPolicy23235 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "getPolicy", "()Ljava/security/Policy;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Policy.staticClass, global::java.security.Policy._getPolicy23235)) as java.security.Policy;
		}
		internal static global::MonoJavaBridge.MethodId _setPolicy23236;
		public static void setPolicy(java.security.Policy arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._setPolicy23236.native == global::System.IntPtr.Zero)
				global::java.security.Policy._setPolicy23236 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "setPolicy", "(Ljava/security/Policy;)V");
			@__env.CallStaticVoidMethod(java.security.Policy.staticClass, global::java.security.Policy._setPolicy23236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Policy23237;
		public Policy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Policy._Policy23237.native == global::System.IntPtr.Zero)
				global::java.security.Policy._Policy23237 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Policy.staticClass, global::java.security.Policy._Policy23237);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNSUPPORTED_EMPTY_COLLECTION23238;
		public static global::java.security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.Policy.staticClass, _UNSUPPORTED_EMPTY_COLLECTION23238)) as java.security.PermissionCollection;
			}
		}
		static Policy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Policy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Policy"));
			global::java.security.Policy._UNSUPPORTED_EMPTY_COLLECTION23238 = @__env.GetStaticFieldIDNoThrow(global::java.security.Policy.staticClass, "UNSUPPORTED_EMPTY_COLLECTION", "Ljava/security/PermissionCollection;");
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
