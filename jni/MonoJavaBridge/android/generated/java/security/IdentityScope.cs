namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.IdentityScope_))]
	public abstract partial class IdentityScope : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdentityScope()
		{
			InitJNI();
		}
		protected IdentityScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22976;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.IdentityScope._toString22976)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.IdentityScope.staticClass, global::java.security.IdentityScope._toString22976)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size22977;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _getSystemScope22978;
		public static global::java.security.IdentityScope getSystemScope() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._getSystemScope22978)) as java.security.IdentityScope;
		}
		internal static global::MonoJavaBridge.MethodId _addIdentity22979;
		public abstract void addIdentity(java.security.Identity arg0);
		internal static global::MonoJavaBridge.MethodId _setSystemScope22980;
		protected static void setSystemScope(java.security.IdentityScope arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._setSystemScope22980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22981;
		public abstract global::java.security.Identity getIdentity(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getIdentity22982;
		public virtual global::java.security.Identity getIdentity(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.IdentityScope._getIdentity22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.IdentityScope.staticClass, global::java.security.IdentityScope._getIdentity22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22983;
		public abstract global::java.security.Identity getIdentity(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeIdentity22984;
		public abstract void removeIdentity(java.security.Identity arg0);
		internal static global::MonoJavaBridge.MethodId _identities22985;
		public abstract global::java.util.Enumeration identities();
		internal static global::MonoJavaBridge.MethodId _IdentityScope22986;
		protected IdentityScope()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22986);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityScope22987;
		public IdentityScope(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityScope22988;
		public IdentityScope(java.lang.String arg0, java.security.IdentityScope arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.IdentityScope.staticClass, global::java.security.IdentityScope._IdentityScope22988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
			global::java.security.IdentityScope._toString22976 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.IdentityScope._size22977 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "size", "()I");
			global::java.security.IdentityScope._getSystemScope22978 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getSystemScope", "()Ljava/security/IdentityScope;");
			global::java.security.IdentityScope._addIdentity22979 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "addIdentity", "(Ljava/security/Identity;)V");
			global::java.security.IdentityScope._setSystemScope22980 = @__env.GetStaticMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "setSystemScope", "(Ljava/security/IdentityScope;)V");
			global::java.security.IdentityScope._getIdentity22981 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;");
			global::java.security.IdentityScope._getIdentity22982 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;");
			global::java.security.IdentityScope._getIdentity22983 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;");
			global::java.security.IdentityScope._removeIdentity22984 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "removeIdentity", "(Ljava/security/Identity;)V");
			global::java.security.IdentityScope._identities22985 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "identities", "()Ljava/util/Enumeration;");
			global::java.security.IdentityScope._IdentityScope22986 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "()V");
			global::java.security.IdentityScope._IdentityScope22987 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.IdentityScope._IdentityScope22988 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.IdentityScope))]
	internal sealed partial class IdentityScope_ : java.security.IdentityScope
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdentityScope_()
		{
			InitJNI();
		}
		internal IdentityScope_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size22989;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.IdentityScope_._size22989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._size22989);
		}
		internal static global::MonoJavaBridge.MethodId _addIdentity22990;
		public override void addIdentity(java.security.Identity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.IdentityScope_._addIdentity22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._addIdentity22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22991;
		public override global::java.security.Identity getIdentity(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.IdentityScope_._getIdentity22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._getIdentity22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentity22992;
		public override global::java.security.Identity getIdentity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.IdentityScope_._getIdentity22992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._getIdentity22992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Identity;
		}
		internal static global::MonoJavaBridge.MethodId _removeIdentity22993;
		public override void removeIdentity(java.security.Identity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.IdentityScope_._removeIdentity22993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._removeIdentity22993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _identities22994;
		public override global::java.util.Enumeration identities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.IdentityScope_._identities22994)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.IdentityScope_.staticClass, global::java.security.IdentityScope_._identities22994)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.IdentityScope_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/IdentityScope"));
			global::java.security.IdentityScope_._size22989 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "size", "()I");
			global::java.security.IdentityScope_._addIdentity22990 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "addIdentity", "(Ljava/security/Identity;)V");
			global::java.security.IdentityScope_._getIdentity22991 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;");
			global::java.security.IdentityScope_._getIdentity22992 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;");
			global::java.security.IdentityScope_._removeIdentity22993 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "removeIdentity", "(Ljava/security/Identity;)V");
			global::java.security.IdentityScope_._identities22994 = @__env.GetMethodIDNoThrow(global::java.security.IdentityScope_.staticClass, "identities", "()Ljava/util/Enumeration;");
		}
	}
}
