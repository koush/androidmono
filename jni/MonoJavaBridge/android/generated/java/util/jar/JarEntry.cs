namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarEntry : java.util.zip.ZipEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarEntry()
		{
			InitJNI();
		}
		protected JarEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.cert.Certificate[] Certificates
		{
			get
			{
				return getCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates27738;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry._getCertificates27738)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getCertificates27738)) as java.security.cert.Certificate[];
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSigners27739;
		public virtual global::java.security.CodeSigner[] getCodeSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry._getCodeSigners27739)) as java.security.CodeSigner[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.CodeSigner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getCodeSigners27739)) as java.security.CodeSigner[];
		}
		public new global::java.util.jar.Attributes Attributes
		{
			get
			{
				return getAttributes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27740;
		public virtual global::java.util.jar.Attributes getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry._getAttributes27740)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getAttributes27740)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27741;
		public JarEntry(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27742;
		public JarEntry(java.util.zip.ZipEntry arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27743;
		public JarEntry(java.util.jar.JarEntry arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarEntry"));
			global::java.util.jar.JarEntry._getCertificates27738 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.util.jar.JarEntry._getCodeSigners27739 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			global::java.util.jar.JarEntry._getAttributes27740 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;");
			global::java.util.jar.JarEntry._JarEntry27741 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.jar.JarEntry._JarEntry27742 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
			global::java.util.jar.JarEntry._JarEntry27743 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/jar/JarEntry;)V");
		}
	}
}
