namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarEntry : java.util.zip.ZipEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getCertificates27857;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._getCertificates27857.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._getCertificates27857 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getCertificates27857) as java.security.cert.Certificate[];
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodeSigners27858;
		public virtual global::java.security.CodeSigner[] getCodeSigners()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._getCodeSigners27858.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._getCodeSigners27858 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.CodeSigner>(this, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getCodeSigners27858) as java.security.CodeSigner[];
		}
		public new global::java.util.jar.Attributes Attributes
		{
			get
			{
				return getAttributes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27859;
		public virtual global::java.util.jar.Attributes getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._getAttributes27859.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._getAttributes27859 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._getAttributes27859) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27860;
		public JarEntry(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._JarEntry27860.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._JarEntry27860 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27861;
		public JarEntry(java.util.zip.ZipEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._JarEntry27861.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._JarEntry27861 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarEntry27862;
		public JarEntry(java.util.jar.JarEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._JarEntry27862.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._JarEntry27862 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/jar/JarEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._JarEntry27862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
