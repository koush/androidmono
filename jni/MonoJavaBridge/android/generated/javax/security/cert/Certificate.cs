namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate()
		{
			InitJNI();
		}
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23671;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate._equals23671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._equals23671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23672;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23673;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.Certificate._hashCode23673);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._hashCode23673);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23674;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23675;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify23676;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey23677;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _Certificate23678;
		public Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._Certificate23678);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate._equals23671 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.cert.Certificate._toString23672 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate._hashCode23673 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::javax.security.cert.Certificate._getEncoded23674 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate._verify23675 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate._verify23676 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate._getPublicKey23677 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::javax.security.cert.Certificate._Certificate23678 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.Certificate))]
	public sealed partial class Certificate_ : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23679;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._toString23679)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._toString23679)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23680;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getEncoded23680)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getEncoded23680)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23681;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify23681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify23681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23682;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify23682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify23682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23683;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getPublicKey23683)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getPublicKey23683)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate_._toString23679 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate_._getEncoded23680 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate_._verify23681 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate_._verify23682 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate_._getPublicKey23683 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
