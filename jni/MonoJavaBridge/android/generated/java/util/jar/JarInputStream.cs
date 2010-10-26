namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarInputStream : java.util.zip.ZipInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarInputStream()
		{
			InitJNI();
		}
		protected JarInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read27875;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.JarInputStream._read27875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._read27875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getManifest27876;
		public virtual global::java.util.jar.Manifest getManifest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream._getManifest27876)) as java.util.jar.Manifest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getManifest27876)) as java.util.jar.Manifest;
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry27877;
		public override global::java.util.zip.ZipEntry getNextEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream._getNextEntry27877)) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getNextEntry27877)) as java.util.zip.ZipEntry;
		}
		public new global::java.util.jar.JarEntry NextJarEntry
		{
			get
			{
				return getNextJarEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextJarEntry27878;
		public virtual global::java.util.jar.JarEntry getNextJarEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream._getNextJarEntry27878)) as java.util.jar.JarEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._getNextJarEntry27878)) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry27879;
		protected override global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream._createZipEntry27879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._createZipEntry27879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _JarInputStream27880;
		public JarInputStream(java.io.InputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._JarInputStream27880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarInputStream27881;
		public JarInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarInputStream.staticClass, global::java.util.jar.JarInputStream._JarInputStream27881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarInputStream"));
			global::java.util.jar.JarInputStream._read27875 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "read", "([BII)I");
			global::java.util.jar.JarInputStream._getManifest27876 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.util.jar.JarInputStream._getNextEntry27877 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
			global::java.util.jar.JarInputStream._getNextJarEntry27878 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "getNextJarEntry", "()Ljava/util/jar/JarEntry;");
			global::java.util.jar.JarInputStream._createZipEntry27879 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.jar.JarInputStream._JarInputStream27880 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Z)V");
			global::java.util.jar.JarInputStream._JarInputStream27881 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
