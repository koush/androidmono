namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.IdentityScope_))]
	public abstract partial class IdentityScope : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdentityScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.IdentityScope.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.IdentityScope._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int size();
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.IdentityScope getSystemScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._m2.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getSystemScope", "()Ljava/security/IdentityScope;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._m2)) as java.security.IdentityScope;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void addIdentity(java.security.Identity arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		protected static void setSystemScope(java.security.IdentityScope arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._m4.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "setSystemScope", "(Ljava/security/IdentityScope;)V");
			@__env.CallStaticVoidMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.security.Identity getIdentity(java.security.PublicKey arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.Identity getIdentity(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope.staticClass, "getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;", ref global::java.security.IdentityScope._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.security.Identity getIdentity(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void removeIdentity(java.security.Identity arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.util.Enumeration identities();
		private static global::MonoJavaBridge.MethodId _m10;
		protected IdentityScope() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._m10.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._m10 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public IdentityScope(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._m11.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._m11 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public IdentityScope(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.IdentityScope._m12.native == global::System.IntPtr.Zero)
				global::java.security.IdentityScope._m12 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IdentityScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.IdentityScope))]
	internal sealed partial class IdentityScope_ : java.security.IdentityScope
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IdentityScope_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.IdentityScope_.staticClass, "size", "()I", ref global::java.security.IdentityScope_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void addIdentity(java.security.Identity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.IdentityScope_.staticClass, "addIdentity", "(Ljava/security/Identity;)V", ref global::java.security.IdentityScope_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.security.Identity getIdentity(java.security.PublicKey arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;", ref global::java.security.IdentityScope_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.security.Identity getIdentity(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;", ref global::java.security.IdentityScope_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Identity;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void removeIdentity(java.security.Identity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.IdentityScope_.staticClass, "removeIdentity", "(Ljava/security/Identity;)V", ref global::java.security.IdentityScope_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.util.Enumeration identities()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.IdentityScope_.staticClass, "identities", "()Ljava/util/Enumeration;", ref global::java.security.IdentityScope_._m5) as java.util.Enumeration;
		}
		static IdentityScope_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
		}
	}
}
