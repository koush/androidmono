namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Signer_))]
	public abstract partial class Signer : java.security.Identity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signer()
		{
			InitJNI();
		}
		protected Signer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23284;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signer._toString23284)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signer.staticClass, global::java.security.Signer._toString23284)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateKey23285;
		public virtual global::java.security.PrivateKey getPrivateKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signer._getPrivateKey23285)) as java.security.PrivateKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signer.staticClass, global::java.security.Signer._getPrivateKey23285)) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyPair23286;
		public virtual void setKeyPair(java.security.KeyPair arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signer._setKeyPair23286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signer.staticClass, global::java.security.Signer._setKeyPair23286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Signer23287;
		public Signer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signer23288;
		public Signer(java.lang.String arg0, java.security.IdentityScope arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signer23289;
		protected Signer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signer.staticClass, global::java.security.Signer._Signer23289);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signer"));
			global::java.security.Signer._toString23284 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Signer._getPrivateKey23285 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "getPrivateKey", "()Ljava/security/PrivateKey;");
			global::java.security.Signer._setKeyPair23286 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "setKeyPair", "(Ljava/security/KeyPair;)V");
			global::java.security.Signer._Signer23287 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.Signer._Signer23288 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V");
			global::java.security.Signer._Signer23289 = @__env.GetMethodIDNoThrow(global::java.security.Signer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signer))]
	public sealed partial class Signer_ : java.security.Signer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signer_()
		{
			InitJNI();
		}
		internal Signer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signer"));
		}
	}
}
