namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarFile : java.util.zip.ZipFile
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.zip.ZipEntry getEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", ref global::java.util.jar.JarFile._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Enumeration entries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.jar.JarFile.staticClass, "entries", "()Ljava/util/Enumeration;", ref global::java.util.jar.JarFile._m1) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", ref global::java.util.jar.JarFile._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, "getManifest", "()Ljava/util/jar/Manifest;", ref global::java.util.jar.JarFile._m3) as java.util.jar.Manifest;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.jar.JarEntry getJarEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, "getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", ref global::java.util.jar.JarFile._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.jar.JarEntry;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public JarFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarFile._m5.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarFile._m5 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public JarFile(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarFile._m6.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarFile._m6 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public JarFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarFile._m7.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarFile._m7 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public JarFile(java.io.File arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarFile._m8.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarFile._m8 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public JarFile(java.io.File arg0, bool arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarFile._m9.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarFile._m9 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;ZI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static global::java.lang.String MANIFEST_NAME
		{
			get
			{
				return "META-INF/MANIFEST.MF";
			}
		}
		static JarFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarFile"));
		}
	}
}
