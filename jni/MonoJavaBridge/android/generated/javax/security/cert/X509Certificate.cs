namespace javax.security.cert
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class X509Certificate : javax.security.cert.Certificate
	{
		internal new static global::java.lang.Class staticClass;
		static X509Certificate()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.security.cert.X509Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected X509Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance14177;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.cert.X509Certificate>(@__env, @__env.CallStaticObjectMethodPtr(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance14177, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance14178;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.cert.X509Certificate>(@__env, @__env.CallStaticObjectMethodPtr(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance14178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVersion14179;
		public abstract int getVersion();
		internal static global::net.sf.jni4net.jni.MethodId _getSerialNumber14180;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerDN14181;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity14182;
		public abstract void checkValidity();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity14183;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectDN14184;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::net.sf.jni4net.jni.MethodId _getNotBefore14185;
		public abstract global::java.util.Date getNotBefore();
		internal static global::net.sf.jni4net.jni.MethodId _getNotAfter14186;
		public abstract global::java.util.Date getNotAfter();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgName14187;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgOID14188;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgParams14189;
		public abstract byte[] getSigAlgParams();
		internal static global::net.sf.jni4net.jni.MethodId _X509Certificate14190;
		public X509Certificate()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._X509Certificate14190, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.security.cert.X509Certificate.staticClass = @__class;
			global::javax.security.cert.X509Certificate._getInstance14177 = @__env.GetStaticMethodID(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getInstance14178 = @__env.GetStaticMethodID(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getVersion14179 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate._getSerialNumber14180 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate._getIssuerDN14181 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._checkValidity14182 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate._checkValidity14183 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate._getSubjectDN14184 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._getNotBefore14185 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getNotAfter14186 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getSigAlgName14187 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgOID14188 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgParams14189 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate._X509Certificate14190 = @__env.GetMethodID(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}
}
