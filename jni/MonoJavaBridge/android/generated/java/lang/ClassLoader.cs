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
		internal static global::MonoJavaBridge.MethodId _loadClass14416;
		protected virtual global::java.lang.Class loadClass(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass14416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass14416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _loadClass14417;
		public virtual global::java.lang.Class loadClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._loadClass14417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._loadClass14417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemClassLoader14418;
		public static global::java.lang.ClassLoader getSystemClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemClassLoader14418)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage14419;
		protected virtual global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackage14419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackage14419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _setSigners14420;
		protected virtual void setSigners(java.lang.Class arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setSigners14420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setSigners14420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream14421;
		public virtual global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResourceAsStream14421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResourceAsStream14421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource14422;
		public virtual global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResource14422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResource14422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResourceAsStream14423;
		public static global::java.io.InputStream getSystemResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResourceAsStream14423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResource14424;
		public static global::java.net.URL getSystemResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResource14424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findClass14425;
		protected virtual global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findClass14425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findClass14425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass14426;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.ProtectionDomain arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass14426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass14426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass14427;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.ProtectionDomain arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass14427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass14427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass14428;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass14428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass14428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass14429;
		protected virtual global::java.lang.Class defineClass(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._defineClass14429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._defineClass14429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass14430;
		protected virtual void resolveClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._resolveClass14430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._resolveClass14430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findSystemClass14431;
		protected virtual global::java.lang.Class findSystemClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findSystemClass14431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findSystemClass14431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findLoadedClass14432;
		protected virtual global::java.lang.Class findLoadedClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLoadedClass14432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLoadedClass14432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getResources14433;
		public virtual global::java.util.Enumeration getResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getResources14433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getResources14433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findResource14434;
		protected virtual global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResource14434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResource14434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources14435;
		protected virtual global::java.util.Enumeration findResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findResources14435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findResources14435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemResources14436;
		public static global::java.util.Enumeration getSystemResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getSystemResources14436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getParent14437;
		public virtual global::java.lang.ClassLoader getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getParent14437)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getParent14437)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _definePackage14438;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.net.URL arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._definePackage14438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._definePackage14438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getPackages14439;
		protected virtual global::java.lang.Package[] getPackages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._getPackages14439)) as java.lang.Package[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._getPackages14439)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary14440;
		protected virtual global::java.lang.String findLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassLoader._findLibrary14440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._findLibrary14440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAssertionStatus14441;
		public virtual void setDefaultAssertionStatus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setDefaultAssertionStatus14441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setDefaultAssertionStatus14441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPackageAssertionStatus14442;
		public virtual void setPackageAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setPackageAssertionStatus14442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setPackageAssertionStatus14442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClassAssertionStatus14443;
		public virtual void setClassAssertionStatus(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._setClassAssertionStatus14443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._setClassAssertionStatus14443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearAssertionStatus14444;
		public virtual void clearAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ClassLoader._clearAssertionStatus14444);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._clearAssertionStatus14444);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader14445;
		protected ClassLoader(java.lang.ClassLoader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader14445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassLoader14446;
		protected ClassLoader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._ClassLoader14446);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
			global::java.lang.ClassLoader._loadClass14416 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;");
			global::java.lang.ClassLoader._loadClass14417 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getSystemClassLoader14418 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._getPackage14419 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._setSigners14420 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V");
			global::java.lang.ClassLoader._getResourceAsStream14421 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getResource14422 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._getSystemResourceAsStream14423 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.ClassLoader._getSystemResource14424 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findClass14425 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass14426 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass14427 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass14428 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._defineClass14429 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "defineClass", "([BII)Ljava/lang/Class;");
			global::java.lang.ClassLoader._resolveClass14430 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "resolveClass", "(Ljava/lang/Class;)V");
			global::java.lang.ClassLoader._findSystemClass14431 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._findLoadedClass14432 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.ClassLoader._getResources14433 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._findResource14434 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.ClassLoader._findResources14435 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getSystemResources14436 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::java.lang.ClassLoader._getParent14437 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;");
			global::java.lang.ClassLoader._definePackage14438 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;");
			global::java.lang.ClassLoader._getPackages14439 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.ClassLoader._findLibrary14440 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.lang.ClassLoader._setDefaultAssertionStatus14441 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V");
			global::java.lang.ClassLoader._setPackageAssertionStatus14442 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._setClassAssertionStatus14443 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V");
			global::java.lang.ClassLoader._clearAssertionStatus14444 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V");
			global::java.lang.ClassLoader._ClassLoader14445 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.ClassLoader._ClassLoader14446 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "()V");
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
