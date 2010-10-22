namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXBuilderParameters : java.security.cert.PKIXParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PKIXBuilderParameters()
		{
			InitJNI();
		}
		protected PKIXBuilderParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23507;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters._toString23507)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._toString23507)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPathLength23508;
		public virtual void setMaxPathLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters._setMaxPathLength23508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._setMaxPathLength23508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxPathLength
		{
			get
			{
				return getMaxPathLength();
			}
			set
			{
				setMaxPathLength(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxPathLength23509;
		public virtual int getMaxPathLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters._getMaxPathLength23509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._getMaxPathLength23509);
		}
		internal static global::MonoJavaBridge.MethodId _PKIXBuilderParameters23510;
		public PKIXBuilderParameters(java.util.Set arg0, java.security.cert.CertSelector arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._PKIXBuilderParameters23510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PKIXBuilderParameters23511;
		public PKIXBuilderParameters(java.security.KeyStore arg0, java.security.cert.CertSelector arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._PKIXBuilderParameters23511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXBuilderParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXBuilderParameters"));
			global::java.security.cert.PKIXBuilderParameters._toString23507 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PKIXBuilderParameters._setMaxPathLength23508 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "setMaxPathLength", "(I)V");
			global::java.security.cert.PKIXBuilderParameters._getMaxPathLength23509 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "getMaxPathLength", "()I");
			global::java.security.cert.PKIXBuilderParameters._PKIXBuilderParameters23510 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "<init>", "(Ljava/util/Set;Ljava/security/cert/CertSelector;)V");
			global::java.security.cert.PKIXBuilderParameters._PKIXBuilderParameters23511 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/security/cert/CertSelector;)V");
		}
	}
}
