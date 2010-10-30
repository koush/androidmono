namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarInputStream : java.util.zip.ZipInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read27876;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._read27876.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._read27876 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._read27876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getManifest27877;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._getManifest27877.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._getManifest27877 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getManifest27877) as java.util.jar.Manifest;
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry27878;
		public override global::java.util.zip.ZipEntry getNextEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._getNextEntry27878.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._getNextEntry27878 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getNextEntry27878) as java.util.zip.ZipEntry;
		}
		public new global::java.util.jar.JarEntry NextJarEntry
		{
			get
			{
				return getNextJarEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextJarEntry27879;
		public virtual global::java.util.jar.JarEntry getNextJarEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._getNextJarEntry27879.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._getNextJarEntry27879 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getNextJarEntry", "()Ljava/util/jar/JarEntry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getNextJarEntry27879) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry27880;
		protected override global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._createZipEntry27880.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._createZipEntry27880 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._createZipEntry27880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _JarInputStream27881;
		public JarInputStream(java.io.InputStream arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._JarInputStream27881.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._JarInputStream27881 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._JarInputStream27881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarInputStream27882;
		public JarInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.JarInputStream._JarInputStream27882.native == global::System.IntPtr.Zero)
				global::java.util.jar.JarInputStream._JarInputStream27882 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._JarInputStream27882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
