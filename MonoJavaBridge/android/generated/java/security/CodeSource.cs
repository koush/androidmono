namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodeSource : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CodeSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22925;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._equals22925.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._equals22925 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._equals22925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22926;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._toString22926.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._toString22926 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._toString22926) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22927;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._hashCode22927.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._hashCode22927 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._hashCode22927);
		}
		public new global::java.net.URL Location
		{
			get
			{
				return getLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocation22928;
		public virtual global::java.net.URL getLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._getLocation22928.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._getLocation22928 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getLocation22928) as java.net.URL;
		}
		public new global::java.security.cert.Certificate[] Certificates
		{
			get
			{
				return getCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates22929;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._getCertificates22929.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._getCertificates22929 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCertificates22929) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _implies22930;
		public virtual bool implies(java.security.CodeSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._implies22930.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._implies22930 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._implies22930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSigners22931;
		public virtual global::java.security.CodeSigner[] getCodeSigners()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._getCodeSigners22931.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._getCodeSigners22931 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.CodeSigner>(this, global::java.security.CodeSource.staticClass, global::java.security.CodeSource._getCodeSigners22931) as java.security.CodeSigner[];
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource22932;
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._CodeSource22932.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._CodeSource22932 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource22932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CodeSource22933;
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSource._CodeSource22933.native == global::System.IntPtr.Zero)
				global::java.security.CodeSource._CodeSource22933 = @__env.GetMethodIDNoThrow(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSource.staticClass, global::java.security.CodeSource._CodeSource22933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CodeSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
