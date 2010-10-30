namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CollectionCertStoreParameters : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CollectionCertStoreParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23614;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CollectionCertStoreParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.CollectionCertStoreParameters._toString23614) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23615;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CollectionCertStoreParameters.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.CollectionCertStoreParameters._clone23615) as java.lang.Object;
		}
		public new global::java.util.Collection Collection
		{
			get
			{
				return getCollection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCollection23616;
		public virtual global::java.util.Collection getCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CollectionCertStoreParameters.staticClass, "getCollection", "()Ljava/util/Collection;", ref global::java.security.cert.CollectionCertStoreParameters._getCollection23616) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _CollectionCertStoreParameters23617;
		public CollectionCertStoreParameters(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23617.native == global::System.IntPtr.Zero)
				global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23617 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CollectionCertStoreParameters23618;
		public CollectionCertStoreParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23618.native == global::System.IntPtr.Zero)
				global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23618 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23618);
			Init(@__env, handle);
		}
		static CollectionCertStoreParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CollectionCertStoreParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CollectionCertStoreParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
