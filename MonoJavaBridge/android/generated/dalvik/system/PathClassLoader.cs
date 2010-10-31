namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.PathClassLoader.staticClass, "toString", "()Ljava/lang/String;", ref global::dalvik.system.PathClassLoader._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.lang.Package getPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::dalvik.system.PathClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", ref global::dalvik.system.PathClassLoader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.system.PathClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::dalvik.system.PathClassLoader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::dalvik.system.PathClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::dalvik.system.PathClassLoader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::dalvik.system.PathClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::dalvik.system.PathClassLoader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::java.lang.String findLibrary(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.PathClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", ref global::dalvik.system.PathClassLoader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PathClassLoader(java.lang.String arg0, java.lang.ClassLoader arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.PathClassLoader._m6.native == global::System.IntPtr.Zero)
				global::dalvik.system.PathClassLoader._m6 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PathClassLoader(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.PathClassLoader._m7.native == global::System.IntPtr.Zero)
				global::dalvik.system.PathClassLoader._m7 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PathClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.PathClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/PathClassLoader"));
		}
	}
}
