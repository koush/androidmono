namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarInputStream : java.util.zip.ZipInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.JarInputStream.staticClass, "read", "([BII)I", ref global::java.util.jar.JarInputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, "getManifest", "()Ljava/util/jar/Manifest;", ref global::java.util.jar.JarInputStream._m1) as java.util.jar.Manifest;
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.zip.ZipEntry getNextEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;", ref global::java.util.jar.JarInputStream._m2) as java.util.zip.ZipEntry;
		}
		public new global::java.util.jar.JarEntry NextJarEntry
		{
			get
			{
				return getNextJarEntry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.jar.JarEntry getNextJarEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, "getNextJarEntry", "()Ljava/util/jar/JarEntry;", ref global::java.util.jar.JarInputStream._m3) as java.util.jar.JarEntry;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", ref global::java.util.jar.JarInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public JarInputStream(java.io.InputStream arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._m5.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._m5 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public JarInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._m6.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._m6 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarInputStream"));
		}
	}
}
