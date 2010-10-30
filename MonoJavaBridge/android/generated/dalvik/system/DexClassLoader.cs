namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DexClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DexClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.lang.Package getPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::dalvik.system.DexClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", ref global::dalvik.system.DexClassLoader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.lang.Class findClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.system.DexClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::dalvik.system.DexClassLoader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.net.URL findResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::dalvik.system.DexClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::dalvik.system.DexClassLoader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::java.lang.String findLibrary(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.DexClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", ref global::dalvik.system.DexClassLoader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DexClassLoader(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.ClassLoader arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.DexClassLoader._m4.native == global::System.IntPtr.Zero)
				global::dalvik.system.DexClassLoader._m4 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static DexClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.DexClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/DexClassLoader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
