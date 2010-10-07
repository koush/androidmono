namespace javax.security.cert
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Certificate : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Certificate()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.security.cert.Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals14169;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.security.cert.Certificate._equals14169, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._equals14169, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14170;
		public abstract new global::java.lang.String toString();
		internal static global::net.sf.jni4net.jni.MethodId _hashCode14171;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::javax.security.cert.Certificate._hashCode14171);
			else
				return @__env.CallNonVirtualIntMethod(this, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._hashCode14171);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded14172;
		public abstract byte[] getEncoded();
		internal static global::net.sf.jni4net.jni.MethodId _verify14173;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::net.sf.jni4net.jni.MethodId _verify14174;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getPublicKey14175;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::net.sf.jni4net.jni.MethodId _Certificate14176;
		public Certificate()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._Certificate14176, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.security.cert.Certificate.staticClass = @__class;
			global::javax.security.cert.Certificate._equals14169 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.cert.Certificate._toString14170 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate._hashCode14171 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::javax.security.cert.Certificate._getEncoded14172 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate._verify14173 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate._verify14174 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate._getPublicKey14175 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::javax.security.cert.Certificate._Certificate14176 = @__env.GetMethodID(global::javax.security.cert.Certificate.staticClass, "<init>", "()V");
		}
	}
}
