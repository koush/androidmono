namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Identity_))]
	public abstract partial class Identity : java.lang.Object, Principal, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Identity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Identity.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.Identity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String toString(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "toString", "(Z)Ljava/lang/String;", ref global::java.security.Identity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Identity._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Identity.staticClass, "hashCode", "()I", ref global::java.security.Identity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.Identity._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.Identity.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.Identity._m5) as java.security.PublicKey;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "getInfo", "()Ljava/lang/String;", ref global::java.security.Identity._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.security.Certificate[] certificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.Certificate>(this, global::java.security.Identity.staticClass, "certificates", "()[Ljava/security/Certificate;", ref global::java.security.Identity._m7) as java.security.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.IdentityScope getScope()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Identity.staticClass, "getScope", "()Ljava/security/IdentityScope;", ref global::java.security.Identity._m8) as java.security.IdentityScope;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "setPublicKey", "(Ljava/security/PublicKey;)V", ref global::java.security.Identity._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setInfo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "setInfo", "(Ljava/lang/String;)V", ref global::java.security.Identity._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "addCertificate", "(Ljava/security/Certificate;)V", ref global::java.security.Identity._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void removeCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "removeCertificate", "(Ljava/security/Certificate;)V", ref global::java.security.Identity._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual bool identityEquals(java.security.Identity arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Identity.staticClass, "identityEquals", "(Ljava/security/Identity;)Z", ref global::java.security.Identity._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected Identity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._m14.native == global::System.IntPtr.Zero)
				global::java.security.Identity._m14 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._m14);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Identity(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._m15.native == global::System.IntPtr.Zero)
				global::java.security.Identity._m15 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public Identity(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._m16.native == global::System.IntPtr.Zero)
				global::java.security.Identity._m16 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Identity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Identity.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Identity"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Identity))]
	internal sealed partial class Identity_ : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Identity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Identity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Identity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Identity"));
		}
	}
}
