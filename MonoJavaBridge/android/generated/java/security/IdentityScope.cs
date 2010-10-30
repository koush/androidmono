namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.IdentityScope_))]
	public abstract partial class IdentityScope : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdentityScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22977;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.IdentityScope.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.IdentityScope._toString22977) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size22978;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _getSystemScope22979;
		public static global::java.security.IdentityScope getSystemScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._getSystemScope22979.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._getSystemScope22979 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getSystemScope", "()Ljava/security/IdentityScope;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._getSystemScope22979)) as java.security.IdentityScope;
		}
		internal static global::MonoJavaBridge.MethodId _addIdentity22980;
		public abstract void addIdentity(java.security.Identity arg0);
		internal static global::MonoJavaBridge.MethodId _setSystemScope22981;
		protected static void setSystemScope(java.security.IdentityScope arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._setSystemScope22981.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._setSystemScope22981 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "setSystemScope", "(Ljava/security/IdentityScope;)V");
			@__env.CallStaticVoidMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._setSystemScope22981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22982;
		public abstract global::java.security.Identity getIdentity(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getIdentity22983;
		public virtual global::java.security.Identity getIdentity(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope.staticClass, "getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;", ref global::java.security.IdentityScope._getIdentity22983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22984;
		public abstract global::java.security.Identity getIdentity(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeIdentity22985;
		public abstract void removeIdentity(java.security.Identity arg0);
		internal static global::MonoJavaBridge.MethodId _identities22986;
		public abstract global::java.util.Enumeration identities();
		internal static global::MonoJavaBridge.MethodId _IdentityScope22987;
		protected IdentityScope() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._IdentityScope22987.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._IdentityScope22987 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22987);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityScope22988;
		public IdentityScope(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._IdentityScope22988.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._IdentityScope22988 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityScope22989;
		public IdentityScope(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._IdentityScope22989.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._IdentityScope22989 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IdentityScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.IdentityScope))]
	internal sealed partial class IdentityScope_ : java.security.IdentityScope
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IdentityScope_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size22990;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.IdentityScope_.staticClass, "size", "()I", ref global::java.security.IdentityScope_._size22990);
		}
		internal static global::MonoJavaBridge.MethodId _addIdentity22991;
		public override void addIdentity(java.security.Identity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.IdentityScope_.staticClass, "addIdentity", "(Ljava/security/Identity;)V", ref global::java.security.IdentityScope_._addIdentity22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22992;
		public override global::java.security.Identity getIdentity(java.security.PublicKey arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;", ref global::java.security.IdentityScope_._getIdentity22992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22993;
		public override global::java.security.Identity getIdentity(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;", ref global::java.security.IdentityScope_._getIdentity22993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _removeIdentity22994;
		public override void removeIdentity(java.security.Identity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.IdentityScope_.staticClass, "removeIdentity", "(Ljava/security/Identity;)V", ref global::java.security.IdentityScope_._removeIdentity22994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _identities22995;
		public override global::java.util.Enumeration identities()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.IdentityScope_.staticClass, "identities", "()Ljava/util/Enumeration;", ref global::java.security.IdentityScope_._identities22995) as java.util.Enumeration;
		}
		static IdentityScope_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
		}
		internal static void InitJNI()
		{
		}
	}
}
