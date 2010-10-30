namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.ClassLoader_))]
	public abstract partial class ClassLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _loadClass20040;
		protected virtual global::java.lang.Class loadClass(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass20040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _loadClass20041;
		public virtual global::java.lang.Class loadClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass20041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemClassLoader20042;
		public static global::java.lang.ClassLoader getSystemClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemClassLoader20042)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage20043;
		protected virtual global::java.lang.Package getPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackage20043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _setSigners20044;
		protected virtual void setSigners(java.lang.Class arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setSigners20044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream20045;
		public virtual global::java.io.InputStream getResourceAsStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResourceAsStream20045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource20046;
		public virtual global::java.net.URL getResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResource20046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResourceAsStream20047;
		public static global::java.io.InputStream getSystemResourceAsStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResourceAsStream20047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResource20048;
		public static global::java.net.URL getSystemResource(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResource20048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findClass20049;
		protected virtual global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findClass20049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass20050;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.ProtectionDomain arg4)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass20050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass20051;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.ProtectionDomain arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass20051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass20052;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass20052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass20053;
		protected virtual global::java.lang.Class defineClass(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass20053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass20054;
		protected virtual void resolveClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._resolveClass20054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findSystemClass20055;
		protected virtual global::java.lang.Class findSystemClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findSystemClass20055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findLoadedClass20056;
		protected virtual global::java.lang.Class findLoadedClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLoadedClass20056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getResources20057;
		public virtual global::java.util.Enumeration getResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResources20057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findResource20058;
		protected virtual global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResource20058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources20059;
		protected virtual global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResources20059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResources20060;
		public static global::java.util.Enumeration getSystemResources(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResources20060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getParent20061;
		public virtual global::java.lang.ClassLoader getParent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getParent20061)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage20062;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.net.URL arg7)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._definePackage20062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPackages20063;
		protected virtual global::java.lang.Package[] getPackages()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackages20063)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary20064;
		protected virtual global::java.lang.String findLibrary(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLibrary20064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAssertionStatus20065;
		public virtual void setDefaultAssertionStatus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setDefaultAssertionStatus20065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPackageAssertionStatus20066;
		public virtual void setPackageAssertionStatus(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setPackageAssertionStatus20066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClassAssertionStatus20067;
		public virtual void setClassAssertionStatus(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setClassAssertionStatus20067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearAssertionStatus20068;
		public virtual void clearAssertionStatus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._clearAssertionStatus20068);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader20069;
		protected ClassLoader(java.lang.ClassLoader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader20069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader20070;
		protected ClassLoader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader20070);
			Init(@__env, handle);
		}
		static ClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
			global::java.lang.ClassLoader._loadClass20040 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;");
			global::java.lang.ClassLoader._loadClass20041 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getSystemClassLoader20042 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._getPackage20043 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._setSigners20044 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V");
			global::java.lang.ClassLoader._getResourceAsStream20045 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getResource20046 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._getSystemResourceAsStream20047 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getSystemResource20048 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findClass20049 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass20050 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass20051 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass20052 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass20053 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "([BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._resolveClass20054 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "resolveClass", "(Ljava/lang/Class;)V");
			global::java.lang.ClassLoader._findSystemClass20055 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._findLoadedClass20056 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getResources20057 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._findResource20058 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findResources20059 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getSystemResources20060 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getParent20061 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._definePackage20062 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._getPackages20063 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.ClassLoader._findLibrary20064 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.ClassLoader._setDefaultAssertionStatus20065 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V");
			global::java.lang.ClassLoader._setPackageAssertionStatus20066 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._setClassAssertionStatus20067 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._clearAssertionStatus20068 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V");
			global::java.lang.ClassLoader._ClassLoader20069 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.ClassLoader._ClassLoader20070 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.ClassLoader))]
	internal sealed partial class ClassLoader_ : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClassLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ClassLoader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
