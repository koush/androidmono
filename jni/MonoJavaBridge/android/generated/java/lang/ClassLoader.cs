namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.ClassLoader_))]
	public abstract partial class ClassLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassLoader()
		{
			InitJNI();
		}
		protected ClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _loadClass19922;
		protected virtual global::java.lang.Class loadClass(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass19922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass19922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _loadClass19923;
		public virtual global::java.lang.Class loadClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass19923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass19923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemClassLoader19924;
		public static global::java.lang.ClassLoader getSystemClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemClassLoader19924)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage19925;
		protected virtual global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackage19925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackage19925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _setSigners19926;
		protected virtual void setSigners(java.lang.Class arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setSigners19926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setSigners19926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream19927;
		public virtual global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResourceAsStream19927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResourceAsStream19927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource19928;
		public virtual global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResource19928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResource19928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResourceAsStream19929;
		public static global::java.io.InputStream getSystemResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResourceAsStream19929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResource19930;
		public static global::java.net.URL getSystemResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResource19930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findClass19931;
		protected virtual global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findClass19931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findClass19931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass19932;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.ProtectionDomain arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass19932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass19932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass19933;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.ProtectionDomain arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass19933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass19933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass19934;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass19934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass19934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass19935;
		protected virtual global::java.lang.Class defineClass(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass19935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass19935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass19936;
		protected virtual void resolveClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._resolveClass19936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._resolveClass19936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findSystemClass19937;
		protected virtual global::java.lang.Class findSystemClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findSystemClass19937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findSystemClass19937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findLoadedClass19938;
		protected virtual global::java.lang.Class findLoadedClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLoadedClass19938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLoadedClass19938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getResources19939;
		public virtual global::java.util.Enumeration getResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResources19939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResources19939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findResource19940;
		protected virtual global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResource19940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResource19940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources19941;
		protected virtual global::java.util.Enumeration findResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResources19941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResources19941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResources19942;
		public static global::java.util.Enumeration getSystemResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResources19942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getParent19943;
		public virtual global::java.lang.ClassLoader getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getParent19943)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getParent19943)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage19944;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.net.URL arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._definePackage19944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._definePackage19944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPackages19945;
		protected virtual global::java.lang.Package[] getPackages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackages19945)) as java.lang.Package[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackages19945)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary19946;
		protected virtual global::java.lang.String findLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLibrary19946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLibrary19946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAssertionStatus19947;
		public virtual void setDefaultAssertionStatus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setDefaultAssertionStatus19947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setDefaultAssertionStatus19947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPackageAssertionStatus19948;
		public virtual void setPackageAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setPackageAssertionStatus19948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setPackageAssertionStatus19948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClassAssertionStatus19949;
		public virtual void setClassAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setClassAssertionStatus19949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setClassAssertionStatus19949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearAssertionStatus19950;
		public virtual void clearAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._clearAssertionStatus19950);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._clearAssertionStatus19950);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader19951;
		protected ClassLoader(java.lang.ClassLoader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader19951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader19952;
		protected ClassLoader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader19952);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
			global::java.lang.ClassLoader._loadClass19922 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;");
			global::java.lang.ClassLoader._loadClass19923 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getSystemClassLoader19924 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._getPackage19925 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._setSigners19926 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V");
			global::java.lang.ClassLoader._getResourceAsStream19927 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getResource19928 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._getSystemResourceAsStream19929 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getSystemResource19930 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findClass19931 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass19932 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass19933 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass19934 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass19935 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "([BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._resolveClass19936 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "resolveClass", "(Ljava/lang/Class;)V");
			global::java.lang.ClassLoader._findSystemClass19937 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._findLoadedClass19938 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getResources19939 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._findResource19940 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findResources19941 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getSystemResources19942 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getParent19943 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._definePackage19944 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._getPackages19945 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.ClassLoader._findLibrary19946 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.ClassLoader._setDefaultAssertionStatus19947 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V");
			global::java.lang.ClassLoader._setPackageAssertionStatus19948 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._setClassAssertionStatus19949 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._clearAssertionStatus19950 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V");
			global::java.lang.ClassLoader._ClassLoader19951 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.ClassLoader._ClassLoader19952 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.ClassLoader))]
	public sealed partial class ClassLoader_ : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassLoader_()
		{
			InitJNI();
		}
		internal ClassLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
		}
	}
}
