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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.util.jar.JarEntry.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;", ref global::java.util.jar.JarEntry._m0) as java.security.cert.Certificate[];
		}
		public new global::java.security.CodeSigner[] CodeSigners
		{
			get
			{
				return getCodeSigners();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.CodeSigner[] getCodeSigners()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.CodeSigner>(this, global::java.util.jar.JarEntry.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;", ref global::java.util.jar.JarEntry._m1) as java.security.CodeSigner[];
		}
		public new global::java.util.jar.Attributes Attributes
		{
			get
			{
				return getAttributes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.jar.Attributes getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarEntry.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;", ref global::java.util.jar.JarEntry._m2) as java.util.jar.Attributes;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public JarEntry(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._m3.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._m3 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public JarEntry(java.util.zip.ZipEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._m4.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._m4 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public JarEntry(java.util.jar.JarEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarEntry._m5.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarEntry._m5 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarEntry.staticClass, "<init>", "(Ljava/util/jar/JarEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarEntry.staticClass, global::java.util.jar.JarEntry._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarEntry"));
		}
	}
}
