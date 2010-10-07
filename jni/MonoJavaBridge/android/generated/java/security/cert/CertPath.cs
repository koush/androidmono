namespace java.security.cert
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CertPath : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static CertPath()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.cert.CertPath), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CertPath(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13305;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.cert.CertPath._equals13305, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._equals13305, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13306;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._toString13306));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._toString13306));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13307;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.cert.CertPath._hashCode13307);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._hashCode13307);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates13308;
		public abstract global::java.util.List getCertificates();
		internal static global::net.sf.jni4net.jni.MethodId _getType13309;
		public virtual global::java.lang.String getType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._getType13309));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._getType13309));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded13310;
		public abstract byte[] getEncoded();
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded13311;
		public abstract byte[] getEncoded(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace13312;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._writeReplace13312));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._writeReplace13312));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncodings13313;
		public abstract global::java.util.Iterator getEncodings();
		internal static global::net.sf.jni4net.jni.MethodId _CertPath13314;
		protected CertPath(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._CertPath13314, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.CertPath.staticClass = @__class;
			global::java.security.cert.CertPath._equals13305 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.CertPath._toString13306 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._hashCode13307 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "hashCode", "()I");
			global::java.security.cert.CertPath._getCertificates13308 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath._getType13309 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getEncoded13310 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath._getEncoded13311 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath._writeReplace13312 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.CertPath._getEncodings13313 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertPath._CertPath13314 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
