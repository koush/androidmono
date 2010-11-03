namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.JarURLConnection_))]
	public abstract partial class JarURLConnection : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.net.JarURLConnection.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;", ref global::java.net.JarURLConnection._m0) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, "getManifest", "()Ljava/util/jar/Manifest;", ref global::java.net.JarURLConnection._m1) as java.util.jar.Manifest;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.jar.Attributes getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;", ref global::java.net.JarURLConnection._m2) as java.util.jar.Attributes;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.jar.Attributes getMainAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;", ref global::java.net.JarURLConnection._m3) as java.util.jar.Attributes;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.net.URL getJarFileURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.JarURLConnection.staticClass, "getJarFileURL", "()Ljava/net/URL;", ref global::java.net.JarURLConnection._m4) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.util.jar.JarFile getJarFile();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.jar.JarEntry getJarEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, "getJarEntry", "()Ljava/util/jar/JarEntry;", ref global::java.net.JarURLConnection._m6) as java.util.jar.JarEntry;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getEntryName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.JarURLConnection.staticClass, "getEntryName", "()Ljava/lang/String;", ref global::java.net.JarURLConnection._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected JarURLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.JarURLConnection._m8.native == global::System.IntPtr.Zero)
				global::java.net.JarURLConnection._m8 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarURLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.JarURLConnection))]
	internal sealed partial class JarURLConnection_ : java.net.JarURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal JarURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.jar.JarFile getJarFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection_.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;", ref global::java.net.JarURLConnection_._m0) as java.util.jar.JarFile;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.JarURLConnection_.staticClass, "connect", "()V", ref global::java.net.JarURLConnection_._m1);
		}
		static JarURLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
		}
	}
}
