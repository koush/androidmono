namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLClassLoader : java.security.SecureClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._m0.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._m0 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URLClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._m1.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._m1 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.net.URLClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.net.URLClassLoader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.URLClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.net.URLClassLoader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.net.URLClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::java.net.URLClassLoader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.util.jar.Manifest arg1, java.net.URL arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;", ref global::java.net.URLClassLoader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLClassLoader.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", ref global::java.net.URLClassLoader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void addURL(java.net.URL arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLClassLoader.staticClass, "addURL", "(Ljava/net/URL;)V", ref global::java.net.URLClassLoader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.URL[] URLs
		{
			get
			{
				return getURLs();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.net.URL[] getURLs()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.net.URL>(this, global::java.net.URLClassLoader.staticClass, "getURLs", "()[Ljava/net/URL;", ref global::java.net.URLClassLoader._m8) as java.net.URL[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._m9.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._m9 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public URLClassLoader(java.net.URL[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._m10.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._m10 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1, java.net.URLStreamHandlerFactory arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._m11.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._m11 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static URLClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLClassLoader"));
		}
	}
}
