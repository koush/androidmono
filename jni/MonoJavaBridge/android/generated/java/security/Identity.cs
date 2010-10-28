namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Identity_))]
	public abstract partial class Identity : java.lang.Object, Principal, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Identity()
		{
			InitJNI();
		}
		protected Identity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22960;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Identity._equals22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._equals22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22961;
		public virtual global::java.lang.String toString(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._toString22961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._toString22961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString22962;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._toString22962)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._toString22962)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22963;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Identity._hashCode22963);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._hashCode22963);
		}
		internal static global::MonoJavaBridge.MethodId _getName22964;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._getName22964)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._getName22964)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey22965;
		public virtual global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._getPublicKey22965)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._getPublicKey22965)) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _getInfo22966;
		public virtual global::java.lang.String getInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._getInfo22966)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._getInfo22966)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _certificates22967;
		public virtual global::java.security.Certificate[] certificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._certificates22967)) as java.security.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._certificates22967)) as java.security.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getScope22968;
		public virtual global::java.security.IdentityScope getScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Identity._getScope22968)) as java.security.IdentityScope;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._getScope22968)) as java.security.IdentityScope;
		}
		internal static global::MonoJavaBridge.MethodId _setPublicKey22969;
		public virtual void setPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Identity._setPublicKey22969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._setPublicKey22969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInfo22970;
		public virtual void setInfo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Identity._setInfo22970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._setInfo22970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCertificate22971;
		public virtual void addCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Identity._addCertificate22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._addCertificate22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCertificate22972;
		public virtual void removeCertificate(java.security.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Identity._removeCertificate22972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._removeCertificate22972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _identityEquals22973;
		protected virtual bool identityEquals(java.security.Identity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Identity._identityEquals22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Identity.staticClass, global::java.security.Identity._identityEquals22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Identity22974;
		protected Identity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22974);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Identity22975;
		public Identity(java.lang.String arg0, java.security.IdentityScope arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Identity22976;
		public Identity(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Identity.staticClass, global::java.security.Identity._Identity22976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Identity.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Identity"));
			global::java.security.Identity._equals22960 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Identity._toString22961 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.security.Identity._toString22962 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Identity._hashCode22963 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "hashCode", "()I");
			global::java.security.Identity._getName22964 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Identity._getPublicKey22965 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.Identity._getInfo22966 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Identity._certificates22967 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "certificates", "()[Ljava/security/Certificate;");
			global::java.security.Identity._getScope22968 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "getScope", "()Ljava/security/IdentityScope;");
			global::java.security.Identity._setPublicKey22969 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "setPublicKey", "(Ljava/security/PublicKey;)V");
			global::java.security.Identity._setInfo22970 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "setInfo", "(Ljava/lang/String;)V");
			global::java.security.Identity._addCertificate22971 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "addCertificate", "(Ljava/security/Certificate;)V");
			global::java.security.Identity._removeCertificate22972 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "removeCertificate", "(Ljava/security/Certificate;)V");
			global::java.security.Identity._identityEquals22973 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "identityEquals", "(Ljava/security/Identity;)Z");
			global::java.security.Identity._Identity22974 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "()V");
			global::java.security.Identity._Identity22975 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::java.security.Identity._Identity22976 = @__env.GetMethodIDNoThrow(global::java.security.Identity.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Identity))]
	internal sealed partial class Identity_ : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Identity_()
		{
			InitJNI();
		}
		internal Identity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Identity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Identity"));
		}
	}
}
