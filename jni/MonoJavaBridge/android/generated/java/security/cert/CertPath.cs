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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12477;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.cert.CertPath._hashCode12477);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._hashCode12477);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12478;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.cert.CertPath._equals12478, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._equals12478, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12479;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._toString12479));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._toString12479));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates12480;
		public abstract global::java.util.List getCertificates();
		internal static global::net.sf.jni4net.jni.MethodId _getType12481;
		public virtual global::java.lang.String getType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._getType12481));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._getType12481));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12482;
		public abstract byte[] getEncoded();
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12483;
		public abstract byte[] getEncoded(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace12484;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.CertPath._writeReplace12484));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._writeReplace12484));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncodings12485;
		public abstract global::java.util.Iterator getEncodings();
		internal static global::net.sf.jni4net.jni.MethodId _CertPath12486;
		protected CertPath(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.cert.CertPath.staticClass, global::java.security.cert.CertPath._CertPath12486, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.CertPath.staticClass = @__class;
			global::java.security.cert.CertPath._hashCode12477 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "hashCode", "()I");
			global::java.security.cert.CertPath._equals12478 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.CertPath._toString12479 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getCertificates12480 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;");
			global::java.security.cert.CertPath._getType12481 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertPath._getEncoded12482 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B");
			global::java.security.cert.CertPath._getEncoded12483 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.cert.CertPath._writeReplace12484 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.CertPath._getEncodings12485 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertPath._CertPath12486 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
