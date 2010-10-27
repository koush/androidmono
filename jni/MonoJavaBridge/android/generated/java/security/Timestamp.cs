namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Timestamp : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Timestamp()
		{
			InitJNI();
		}
		internal Timestamp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23408;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Timestamp._equals23408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Timestamp.staticClass, global::java.security.Timestamp._equals23408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23409;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Timestamp._toString23409)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Timestamp.staticClass, global::java.security.Timestamp._toString23409)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23410;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Timestamp._hashCode23410);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Timestamp.staticClass, global::java.security.Timestamp._hashCode23410);
		}
		public new global::java.security.cert.CertPath SignerCertPath
		{
			get
			{
				return getSignerCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSignerCertPath23411;
		public global::java.security.cert.CertPath getSignerCertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Timestamp._getSignerCertPath23411)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Timestamp.staticClass, global::java.security.Timestamp._getSignerCertPath23411)) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23412;
		public global::java.util.Date getTimestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Timestamp._getTimestamp23412)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Timestamp.staticClass, global::java.security.Timestamp._getTimestamp23412)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _Timestamp23413;
		public Timestamp(java.util.Date arg0, java.security.cert.CertPath arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Timestamp.staticClass, global::java.security.Timestamp._Timestamp23413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Timestamp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Timestamp"));
			global::java.security.Timestamp._equals23408 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Timestamp._toString23409 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Timestamp._hashCode23410 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "hashCode", "()I");
			global::java.security.Timestamp._getSignerCertPath23411 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;");
			global::java.security.Timestamp._getTimestamp23412 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "getTimestamp", "()Ljava/util/Date;");
			global::java.security.Timestamp._Timestamp23413 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V");
		}
	}
}
