namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.ClassLoader_))]
	public abstract partial class ClassLoader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.lang.Class loadClass(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Class loadClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.ClassLoader getSystemClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m2.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m2)) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::java.lang.Package getPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", ref global::java.lang.ClassLoader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void setSigners(java.lang.Class arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V", ref global::java.lang.ClassLoader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.io.InputStream getResourceAsStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.lang.ClassLoader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.net.URL getResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.lang.ClassLoader.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.lang.ClassLoader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.io.InputStream getSystemResourceAsStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m7.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.net.URL getSystemResource(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m8.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.ProtectionDomain arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.ProtectionDomain arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::java.lang.Class defineClass(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "defineClass", "([BII)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual void resolveClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "resolveClass", "(Ljava/lang/Class;)V", ref global::java.lang.ClassLoader._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual global::java.lang.Class findSystemClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual global::java.lang.Class findLoadedClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.ClassLoader.staticClass, "findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::java.lang.ClassLoader._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.util.Enumeration getResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.lang.ClassLoader.staticClass, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::java.lang.ClassLoader._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.lang.ClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.lang.ClassLoader._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.lang.ClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::java.lang.ClassLoader._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.util.Enumeration getSystemResources(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m20.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m20 = @__env.GetStaticMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.ClassLoader getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, "getParent", "()Ljava/lang/ClassLoader;", ref global::java.lang.ClassLoader._m21) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected virtual global::java.lang.Package definePackage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.net.URL arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ClassLoader.staticClass, "definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", ref global::java.lang.ClassLoader._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual global::java.lang.Package[] getPackages()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Package>(this, global::java.lang.ClassLoader.staticClass, "getPackages", "()[Ljava/lang/Package;", ref global::java.lang.ClassLoader._m23) as java.lang.Package[];
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected virtual global::java.lang.String findLibrary(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.lang.ClassLoader._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setDefaultAssertionStatus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "setDefaultAssertionStatus", "(Z)V", ref global::java.lang.ClassLoader._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setPackageAssertionStatus(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "setPackageAssertionStatus", "(Ljava/lang/String;Z)V", ref global::java.lang.ClassLoader._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setClassAssertionStatus(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "setClassAssertionStatus", "(Ljava/lang/String;Z)V", ref global::java.lang.ClassLoader._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void clearAssertionStatus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ClassLoader.staticClass, "clearAssertionStatus", "()V", ref global::java.lang.ClassLoader._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected ClassLoader(java.lang.ClassLoader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m29.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m29 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected ClassLoader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassLoader._m30.native == global::System.IntPtr.Zero)
				global::java.lang.ClassLoader._m30 = @__env.GetMethodIDNoThrow(global::java.lang.ClassLoader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassLoader.staticClass, global::java.lang.ClassLoader._m30);
			Init(@__env, handle);
		}
		static ClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassLoader"));
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
	}
}
