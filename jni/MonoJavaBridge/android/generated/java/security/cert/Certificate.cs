namespace java.security.cert
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Certificate : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Certificate()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.cert.Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13315;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.cert.Certificate._equals13315, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._equals13315, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13316;
		public abstract new global::java.lang.String toString();
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13317;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.cert.Certificate._hashCode13317);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._hashCode13317);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType13318;
		public virtual global::java.lang.String getType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.Certificate._getType13318));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._getType13318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded13319;
		public abstract byte[] getEncoded();
		internal static global::net.sf.jni4net.jni.MethodId _verify13320;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::net.sf.jni4net.jni.MethodId _verify13321;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getPublicKey13322;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace13323;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.Certificate._writeReplace13323));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._writeReplace13323));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Certificate13324;
		protected Certificate(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._Certificate13324, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.Certificate.staticClass = @__class;
			global::java.security.cert.Certificate._equals13315 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.Certificate._toString13316 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._hashCode13317 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::java.security.cert.Certificate._getType13318 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._getEncoded13319 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::java.security.cert.Certificate._verify13320 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.Certificate._verify13321 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.Certificate._getPublicKey13322 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.Certificate._writeReplace13323 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.Certificate._Certificate13324 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
