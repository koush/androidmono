namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLClassLoader : java.security.SecureClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLClassLoader()
		{
			InitJNI();
		}
		protected URLClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21789;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._newInstance21789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URLClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21790;
		public static global::java.net.URLClassLoader newInstance(java.net.URL[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._newInstance21790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _findClass21791;
		protected override global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._findClass21791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._findClass21791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findResource21792;
		public virtual global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._findResource21792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._findResource21792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources21793;
		public virtual global::java.util.Enumeration findResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._findResources21793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._findResources21793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage21794;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.util.jar.Manifest arg1, java.net.URL arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._definePackage21794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._definePackage21794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions21795;
		protected override global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._getPermissions21795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._getPermissions21795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _addURL21796;
		protected virtual void addURL(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLClassLoader._addURL21796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._addURL21796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.URL[] URLs
		{
			get
			{
				return getURLs();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getURLs21797;
		public virtual global::java.net.URL[] getURLs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLClassLoader._getURLs21797)) as java.net.URL[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._getURLs21797)) as java.net.URL[];
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21798;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21799;
		public URLClassLoader(java.net.URL[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLClassLoader21800;
		public URLClassLoader(java.net.URL[] arg0, java.lang.ClassLoader arg1, java.net.URLStreamHandlerFactory arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLClassLoader.staticClass, global::java.net.URLClassLoader._URLClassLoader21800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLClassLoader"));
			global::java.net.URLClassLoader._newInstance21789 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;");
			global::java.net.URLClassLoader._newInstance21790 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;");
			global::java.net.URLClassLoader._findClass21791 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.net.URLClassLoader._findResource21792 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.net.URLClassLoader._findResources21793 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.net.URLClassLoader._definePackage21794 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;");
			global::java.net.URLClassLoader._getPermissions21795 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;");
			global::java.net.URLClassLoader._addURL21796 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "addURL", "(Ljava/net/URL;)V");
			global::java.net.URLClassLoader._getURLs21797 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "getURLs", "()[Ljava/net/URL;");
			global::java.net.URLClassLoader._URLClassLoader21798 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;)V");
			global::java.net.URLClassLoader._URLClassLoader21799 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;)V");
			global::java.net.URLClassLoader._URLClassLoader21800 = @__env.GetMethodIDNoThrow(global::java.net.URLClassLoader.staticClass, "<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V");
		}
	}
}
