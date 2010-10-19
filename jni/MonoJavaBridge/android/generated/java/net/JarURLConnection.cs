namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.JarURLConnection_))]
	public abstract partial class JarURLConnection : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarURLConnection()
		{
			InitJNI();
		}
		protected JarURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates15898;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getCertificates15898)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getCertificates15898)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getManifest15899;
		public virtual global::java.util.jar.Manifest getManifest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getManifest15899)) as java.util.jar.Manifest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getManifest15899)) as java.util.jar.Manifest;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes15900;
		public virtual global::java.util.jar.Attributes getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getAttributes15900)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getAttributes15900)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getMainAttributes15901;
		public virtual global::java.util.jar.Attributes getMainAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getMainAttributes15901)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getMainAttributes15901)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFileURL15902;
		public virtual global::java.net.URL getJarFileURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getJarFileURL15902)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarFileURL15902)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFile15903;
		public abstract global::java.util.jar.JarFile getJarFile();
		internal static global::MonoJavaBridge.MethodId _getJarEntry15904;
		public virtual global::java.util.jar.JarEntry getJarEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getJarEntry15904)) as java.util.jar.JarEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarEntry15904)) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryName15905;
		public virtual global::java.lang.String getEntryName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getEntryName15905)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getEntryName15905)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JarURLConnection15906;
		protected JarURLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._JarURLConnection15906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection._getCertificates15898 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.net.JarURLConnection._getManifest15899 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.net.JarURLConnection._getAttributes15900 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getMainAttributes15901 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getJarFileURL15902 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFileURL", "()Ljava/net/URL;");
			global::java.net.JarURLConnection._getJarFile15903 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection._getJarEntry15904 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarEntry", "()Ljava/util/jar/JarEntry;");
			global::java.net.JarURLConnection._getEntryName15905 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getEntryName", "()Ljava/lang/String;");
			global::java.net.JarURLConnection._JarURLConnection15906 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.JarURLConnection))]
	public sealed partial class JarURLConnection_ : java.net.JarURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JarURLConnection_()
		{
			InitJNI();
		}
		internal JarURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getJarFile15907;
		public override global::java.util.jar.JarFile getJarFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection_._getJarFile15907)) as java.util.jar.JarFile;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection_.staticClass, global::java.net.JarURLConnection_._getJarFile15907)) as java.util.jar.JarFile;
		}
		internal static global::MonoJavaBridge.MethodId _connect15908;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.JarURLConnection_._connect15908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.JarURLConnection_.staticClass, global::java.net.JarURLConnection_._connect15908);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection_._getJarFile15907 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection_._connect15908 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "connect", "()V");
		}
	}
}
