namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarFile : java.util.zip.ZipFile
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEntry27865;
		public override global::java.util.zip.ZipEntry getEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getEntry27865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _entries27866;
		public override global::java.util.Enumeration entries()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._entries27866)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream27867;
		public override global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getInputStream27867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getManifest27868;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getManifest27868)) as java.util.jar.Manifest;
		}
		internal static global::MonoJavaBridge.MethodId _getJarEntry27869;
		public virtual global::java.util.jar.JarEntry getJarEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getJarEntry27869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _JarFile27870;
		public JarFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile27870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile27871;
		public JarFile(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile27871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile27872;
		public JarFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile27872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile27873;
		public JarFile(java.io.File arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile27873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile27874;
		public JarFile(java.io.File arg0, bool arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile27874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::java.util.jar.JarFile._getEntry27865 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.jar.JarFile._entries27866 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.util.jar.JarFile._getInputStream27867 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;");
			global::java.util.jar.JarFile._getManifest27868 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.util.jar.JarFile._getJarEntry27869 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;");
			global::java.util.jar.JarFile._JarFile27870 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.jar.JarFile._JarFile27871 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.util.jar.JarFile._JarFile27872 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.jar.JarFile._JarFile27873 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.util.jar.JarFile._JarFile27874 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;ZI)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
