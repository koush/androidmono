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
		internal static global::MonoJavaBridge.MethodId _getCertificates21478;
		public virtual global::java.security.cert.Certificate[] getCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getCertificates21478)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getCertificates21478)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getManifest21479;
		public virtual global::java.util.jar.Manifest getManifest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getManifest21479)) as java.util.jar.Manifest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getManifest21479)) as java.util.jar.Manifest;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes21480;
		public virtual global::java.util.jar.Attributes getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getAttributes21480)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getAttributes21480)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getMainAttributes21481;
		public virtual global::java.util.jar.Attributes getMainAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getMainAttributes21481)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getMainAttributes21481)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFileURL21482;
		public virtual global::java.net.URL getJarFileURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getJarFileURL21482)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarFileURL21482)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFile21483;
		public abstract global::java.util.jar.JarFile getJarFile();
		internal static global::MonoJavaBridge.MethodId _getJarEntry21484;
		public virtual global::java.util.jar.JarEntry getJarEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getJarEntry21484)) as java.util.jar.JarEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarEntry21484)) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryName21485;
		public virtual global::java.lang.String getEntryName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection._getEntryName21485)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getEntryName21485)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JarURLConnection21486;
		protected JarURLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._JarURLConnection21486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection._getCertificates21478 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.net.JarURLConnection._getManifest21479 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.net.JarURLConnection._getAttributes21480 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getMainAttributes21481 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getJarFileURL21482 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFileURL", "()Ljava/net/URL;");
			global::java.net.JarURLConnection._getJarFile21483 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection._getJarEntry21484 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarEntry", "()Ljava/util/jar/JarEntry;");
			global::java.net.JarURLConnection._getEntryName21485 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getEntryName", "()Ljava/lang/String;");
			global::java.net.JarURLConnection._JarURLConnection21486 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
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
		internal static global::MonoJavaBridge.MethodId _getJarFile21487;
		public override global::java.util.jar.JarFile getJarFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection_._getJarFile21487)) as java.util.jar.JarFile;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.JarURLConnection_.staticClass, global::java.net.JarURLConnection_._getJarFile21487)) as java.util.jar.JarFile;
		}
		internal static global::MonoJavaBridge.MethodId _connect21488;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.JarURLConnection_._connect21488);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.JarURLConnection_.staticClass, global::java.net.JarURLConnection_._connect21488);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection_._getJarFile21487 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection_._connect21488 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "connect", "()V");
		}
	}
}
