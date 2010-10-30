namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Identity_))]
	public abstract partial class Identity : java.lang.Object, Principal, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Identity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22960;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Identity.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.Identity._equals22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22961;
		public virtual global::java.lang.String toString(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "toString", "(Z)Ljava/lang/String;", ref global::java.security.Identity._toString22961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString22962;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Identity._toString22962) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22963;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Identity.staticClass, "hashCode", "()I", ref global::java.security.Identity._hashCode22963);
		}
		internal static global::MonoJavaBridge.MethodId _getName22964;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.Identity._getName22964) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey22965;
		public virtual global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.Identity.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.Identity._getPublicKey22965) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _getInfo22966;
		public virtual global::java.lang.String getInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Identity.staticClass, "getInfo", "()Ljava/lang/String;", ref global::java.security.Identity._getInfo22966) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _certificates22967;
		public virtual global::java.security.Certificate[] certificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.Certificate>(this, global::java.security.Identity.staticClass, "certificates", "()[Ljava/security/Certificate;", ref global::java.security.Identity._certificates22967) as java.security.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getScope22968;
		public virtual global::java.security.IdentityScope getScope()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Identity.staticClass, "getScope", "()Ljava/security/IdentityScope;", ref global::java.security.Identity._getScope22968) as java.security.IdentityScope;
		}
		internal static global::MonoJavaBridge.MethodId _setPublicKey22969;
		public virtual void setPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "setPublicKey", "(Ljava/security/PublicKey;)V", ref global::java.security.Identity._setPublicKey22969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInfo22970;
		public virtual void setInfo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "setInfo", "(Ljava/lang/String;)V", ref global::java.security.Identity._setInfo22970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCertificate22971;
		public virtual void addCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "addCertificate", "(Ljava/security/Certificate;)V", ref global::java.security.Identity._addCertificate22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCertificate22972;
		public virtual void removeCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Identity.staticClass, "removeCertificate", "(Ljava/security/Certificate;)V", ref global::java.security.Identity._removeCertificate22972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _identityEquals22973;
		protected virtual bool identityEquals(java.security.Identity arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Identity.staticClass, "identityEquals", "(Ljava/security/Identity;)Z", ref global::java.security.Identity._identityEquals22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Identity22974;
		protected Identity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._Identity22974.native == global::System.IntPtr.Zero)
				global::java.security.Identity._Identity22974 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22974);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Identity22975;
		public Identity(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._Identity22975.native == global::System.IntPtr.Zero)
				global::java.security.Identity._Identity22975 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Identity22976;
		public Identity(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Identity._Identity22976.native == global::System.IntPtr.Zero)
				global::java.security.Identity._Identity22976 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Identity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Identity.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Identity"));
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
