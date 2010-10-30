namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLClassLoader : java.security.SecureClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21908;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._newInstance21908.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._newInstance21908 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._newInstance21908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URLClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21909;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._newInstance21909.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._newInstance21909 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._newInstance21909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _findClass21910;
		protected override global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.net.URLClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.net.URLClassLoader._findClass21910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findResource21911;
		public virtual global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.URLClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.net.URLClassLoader._findResource21911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources21912;
		public virtual global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.net.URLClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::java.net.URLClassLoader._findResources21912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage21913;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.util.jar.Manifest arg1, java.net.URL arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;", ref global::java.net.URLClassLoader._definePackage21913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions21914;
		protected override global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLClassLoader.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", ref global::java.net.URLClassLoader._getPermissions21914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _addURL21915;
		protected virtual void addURL(java.net.URL arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLClassLoader.staticClass, "addURL", "(Ljava/net/URL;)V", ref global::java.net.URLClassLoader._addURL21915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.URL[] URLs
		{
			get
			{
				return getURLs();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getURLs21916;
		public virtual global::java.net.URL[] getURLs()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.net.URL>(this, global::java.net.URLClassLoader.staticClass, "getURLs", "()[Ljava/net/URL;", ref global::java.net.URLClassLoader._getURLs21916) as java.net.URL[];
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21917;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._URLClassLoader21917.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._URLClassLoader21917 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21918;
		public URLClassLoader(java.net.URL[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._URLClassLoader21918.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._URLClassLoader21918 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21919;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1, java.net.URLStreamHandlerFactory arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLClassLoader._URLClassLoader21919.native == global::System.IntPtr.Zero)
				global::java.net.URLClassLoader._URLClassLoader21919 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static URLClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLClassLoader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
