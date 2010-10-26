namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CollectionCertStoreParameters : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CollectionCertStoreParameters()
		{
			InitJNI();
		}
		protected CollectionCertStoreParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23613;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters._toString23613)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._toString23613)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23614;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters._clone23614)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._clone23614)) as java.lang.Object;
		}
		public new global::java.util.Collection Collection
		{
			get
			{
				return getCollection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCollection23615;
		public virtual global::java.util.Collection getCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters._getCollection23615)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._getCollection23615)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _CollectionCertStoreParameters23616;
		public CollectionCertStoreParameters(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CollectionCertStoreParameters23617;
		public CollectionCertStoreParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CollectionCertStoreParameters.staticClass, global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23617);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CollectionCertStoreParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CollectionCertStoreParameters"));
			global::java.security.cert.CollectionCertStoreParameters._toString23613 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CollectionCertStoreParameters._clone23614 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.CollectionCertStoreParameters._getCollection23615 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "getCollection", "()Ljava/util/Collection;");
			global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23616 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.security.cert.CollectionCertStoreParameters._CollectionCertStoreParameters23617 = @__env.GetMethodIDNoThrow(global::java.security.cert.CollectionCertStoreParameters.staticClass, "<init>", "()V");
		}
	}
}
