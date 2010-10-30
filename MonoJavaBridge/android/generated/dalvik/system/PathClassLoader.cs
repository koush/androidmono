namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18597;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.PathClassLoader.staticClass, "toString", "()Ljava/lang/String;", ref global::dalvik.system.PathClassLoader._toString18597) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage18598;
		protected override global::java.lang.Package getPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::dalvik.system.PathClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", ref global::dalvik.system.PathClassLoader._getPackage18598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _findClass18599;
		protected override global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.system.PathClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::dalvik.system.PathClassLoader._findClass18599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findResource18600;
		protected override global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::dalvik.system.PathClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::dalvik.system.PathClassLoader._findResource18600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources18601;
		protected override global::java.util.Enumeration findResources(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::dalvik.system.PathClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::dalvik.system.PathClassLoader._findResources18601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary18602;
		protected override global::java.lang.String findLibrary(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.PathClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", ref global::dalvik.system.PathClassLoader._findLibrary18602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PathClassLoader18603;
		public PathClassLoader(java.lang.String arg0, java.lang.ClassLoader arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.PathClassLoader._PathClassLoader18603.native == global::System.IntPtr.Zero)
				global::dalvik.system.PathClassLoader._PathClassLoader18603 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._PathClassLoader18603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathClassLoader18604;
		public PathClassLoader(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.PathClassLoader._PathClassLoader18604.native == global::System.IntPtr.Zero)
				global::dalvik.system.PathClassLoader._PathClassLoader18604 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._PathClassLoader18604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PathClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.PathClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/PathClassLoader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
