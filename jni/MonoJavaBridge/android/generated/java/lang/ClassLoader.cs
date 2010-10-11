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
		internal static global::MonoJavaBridge.MethodId _loadClass12884;
		protected virtual global::java.lang.Class loadClass(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass12884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass12884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _loadClass12885;
		public virtual global::java.lang.Class loadClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemClassLoader12886;
		public static global::java.lang.ClassLoader getSystemClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemClassLoader12886)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage12887;
		protected virtual global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackage12887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackage12887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _setSigners12888;
		protected virtual void setSigners(java.lang.Class arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setSigners12888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setSigners12888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream12889;
		public virtual global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResourceAsStream12889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResourceAsStream12889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource12890;
		public virtual global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResource12890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResource12890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResourceAsStream12891;
		public static global::java.io.InputStream getSystemResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResourceAsStream12891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResource12892;
		public static global::java.net.URL getSystemResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResource12892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findClass12893;
		protected virtual global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findClass12893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findClass12893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass12894;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.ProtectionDomain arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass12894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass12894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass12895;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.ProtectionDomain arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass12895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass12895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass12896;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass12896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass12896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass12897;
		protected virtual global::java.lang.Class defineClass(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass12897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass12897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass12898;
		protected virtual void resolveClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._resolveClass12898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._resolveClass12898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findSystemClass12899;
		protected virtual global::java.lang.Class findSystemClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findSystemClass12899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findSystemClass12899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findLoadedClass12900;
		protected virtual global::java.lang.Class findLoadedClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLoadedClass12900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLoadedClass12900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getResources12901;
		public virtual global::java.util.Enumeration getResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResources12901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResources12901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findResource12902;
		protected virtual global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResource12902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResource12902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources12903;
		protected virtual global::java.util.Enumeration findResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResources12903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResources12903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResources12904;
		public static global::java.util.Enumeration getSystemResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResources12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getParent12905;
		public virtual global::java.lang.ClassLoader getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getParent12905)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getParent12905)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage12906;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.net.URL arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._definePackage12906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._definePackage12906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPackages12907;
		protected virtual global::java.lang.Package[] getPackages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackages12907)) as java.lang.Package[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackages12907)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary12908;
		protected virtual global::java.lang.String findLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLibrary12908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLibrary12908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAssertionStatus12909;
		public virtual void setDefaultAssertionStatus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setDefaultAssertionStatus12909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setDefaultAssertionStatus12909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPackageAssertionStatus12910;
		public virtual void setPackageAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setPackageAssertionStatus12910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setPackageAssertionStatus12910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClassAssertionStatus12911;
		public virtual void setClassAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setClassAssertionStatus12911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setClassAssertionStatus12911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearAssertionStatus12912;
		public virtual void clearAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._clearAssertionStatus12912);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._clearAssertionStatus12912);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader12913;
		protected ClassLoader(java.lang.ClassLoader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader12913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader12914;
		protected ClassLoader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader12914);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
			global::java.lang.ClassLoader._loadClass12884 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;");
			global::java.lang.ClassLoader._loadClass12885 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getSystemClassLoader12886 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._getPackage12887 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._setSigners12888 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V");
			global::java.lang.ClassLoader._getResourceAsStream12889 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getResource12890 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._getSystemResourceAsStream12891 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getSystemResource12892 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findClass12893 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass12894 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass12895 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass12896 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass12897 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "([BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._resolveClass12898 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "resolveClass", "(Ljava/lang/Class;)V");
			global::java.lang.ClassLoader._findSystemClass12899 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._findLoadedClass12900 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getResources12901 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._findResource12902 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findResources12903 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getSystemResources12904 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getParent12905 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._definePackage12906 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._getPackages12907 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.ClassLoader._findLibrary12908 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.ClassLoader._setDefaultAssertionStatus12909 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V");
			global::java.lang.ClassLoader._setPackageAssertionStatus12910 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._setClassAssertionStatus12911 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._clearAssertionStatus12912 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V");
			global::java.lang.ClassLoader._ClassLoader12913 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.ClassLoader._ClassLoader12914 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "()V");
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
