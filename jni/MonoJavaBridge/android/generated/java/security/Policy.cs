namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Policy_))]
	public abstract partial class Policy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Policy()
		{
			InitJNI();
		}
		protected Policy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23110;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Policy._getPermissions23110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._getPermissions23110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23111;
		public virtual global::java.security.PermissionCollection getPermissions(java.security.ProtectionDomain arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Policy._getPermissions23111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._getPermissions23111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _implies23112;
		public virtual bool implies(java.security.ProtectionDomain arg0, java.security.Permission arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Policy._implies23112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._implies23112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getType23113;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Policy._getType23113)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._getType23113)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23114;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Policy._getProvider23114)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._getProvider23114)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _refresh23115;
		public virtual void refresh() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Policy._refresh23115);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Policy.staticClass, global::java.security.Policy._refresh23115);
		}
		internal static global::MonoJavaBridge.MethodId _getPolicy23116;
		public static global::java.security.Policy getPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Policy.staticClass, global::java.security.Policy._getPolicy23116)) as java.security.Policy;
		}
		internal static global::MonoJavaBridge.MethodId _setPolicy23117;
		public static void setPolicy(java.security.Policy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.Policy.staticClass, global::java.security.Policy._setPolicy23117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Policy23118;
		public Policy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Policy.staticClass, global::java.security.Policy._Policy23118);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNSUPPORTED_EMPTY_COLLECTION23119;
		public static global::java.security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.Policy.staticClass, _UNSUPPORTED_EMPTY_COLLECTION23119)) as java.security.PermissionCollection;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Policy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Policy"));
			global::java.security.Policy._getPermissions23110 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;");
			global::java.security.Policy._getPermissions23111 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;");
			global::java.security.Policy._implies23112 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "implies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z");
			global::java.security.Policy._getType23113 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.Policy._getProvider23114 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.Policy._refresh23115 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "refresh", "()V");
			global::java.security.Policy._getPolicy23116 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "getPolicy", "()Ljava/security/Policy;");
			global::java.security.Policy._setPolicy23117 = @__env.GetStaticMethodIDNoThrow(global::java.security.Policy.staticClass, "setPolicy", "(Ljava/security/Policy;)V");
			global::java.security.Policy._Policy23118 = @__env.GetMethodIDNoThrow(global::java.security.Policy.staticClass, "<init>", "()V");
			global::java.security.Policy._UNSUPPORTED_EMPTY_COLLECTION23119 = @__env.GetStaticFieldIDNoThrow(global::java.security.Policy.staticClass, "UNSUPPORTED_EMPTY_COLLECTION", "Ljava/security/PermissionCollection;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Policy))]
	public sealed partial class Policy_ : java.security.Policy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Policy_()
		{
			InitJNI();
		}
		internal Policy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Policy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Policy"));
		}
	}
}
