namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodeSource : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CodeSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.CodeSource._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.CodeSource._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.CodeSource.staticClass, "hashCode", "()I", ref global::java.security.CodeSource._m2);
		}
		public new global::java.net.URL Location
		{
			get
			{
				return getLocation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.net.URL getLocation()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;", ref global::java.security.CodeSource._m3) as java.net.URL;
		}
		public new global::java.security.cert.Certificate[] Certificates
		{
			get
			{
				return getCertificates();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;", ref global::java.security.CodeSource._m4) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool implies(java.security.CodeSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z", ref global::java.security.CodeSource._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.CodeSigner[] getCodeSigners()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.CodeSigner>(this, global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;", ref global::java.security.CodeSource._m6) as java.security.CodeSigner[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._m7.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._m7 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._m8.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._m8 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CodeSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSource"));
		}
	}
}
