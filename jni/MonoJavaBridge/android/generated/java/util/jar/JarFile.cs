namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JarFile : java.util.zip.ZipFile
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarFile()
		{
			InitJNI();
		}
		protected JarFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEntry21916;
		public override global::java.util.zip.ZipEntry getEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarFile._getEntry21916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getEntry21916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _entries21917;
		public override global::java.util.Enumeration entries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarFile._entries21917)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._entries21917)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21918;
		public override global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarFile._getInputStream21918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getInputStream21918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		public new global::java.util.jar.Manifest Manifest
		{
			get
			{
				return getManifest();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getManifest21919;
		public virtual global::java.util.jar.Manifest getManifest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarFile._getManifest21919)) as java.util.jar.Manifest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getManifest21919)) as java.util.jar.Manifest;
		}
		internal static global::MonoJavaBridge.MethodId _getJarEntry21920;
		public virtual global::java.util.jar.JarEntry getJarEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.JarFile._getJarEntry21920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.JarEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._getJarEntry21920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _JarFile21921;
		public JarFile(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile21921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile21922;
		public JarFile(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile21922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile21923;
		public JarFile(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile21923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile21924;
		public JarFile(java.io.File arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile21924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JarFile21925;
		public JarFile(java.io.File arg0, bool arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.JarFile.staticClass, global::java.util.jar.JarFile._JarFile21925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static global::java.lang.String MANIFEST_NAME
		{
			get
			{
				return "META-INF/MANIFEST.MF";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.JarFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/JarFile"));
			global::java.util.jar.JarFile._getEntry21916 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.jar.JarFile._entries21917 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.util.jar.JarFile._getInputStream21918 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;");
			global::java.util.jar.JarFile._getManifest21919 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.util.jar.JarFile._getJarEntry21920 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;");
			global::java.util.jar.JarFile._JarFile21921 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.jar.JarFile._JarFile21922 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.util.jar.JarFile._JarFile21923 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.jar.JarFile._JarFile21924 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.util.jar.JarFile._JarFile21925 = @__env.GetMethodIDNoThrow(global::java.util.jar.JarFile.staticClass, "<init>", "(Ljava/io/File;ZI)V");
		}
	}
}
