namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DexClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DexClassLoader()
		{
			InitJNI();
		}
		protected DexClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPackage13044;
		protected override global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader._getPackage13044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._getPackage13044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _findClass13045;
		protected override global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader._findClass13045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._findClass13045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findResource13046;
		protected override global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader._findResource13046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._findResource13046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary13047;
		protected override global::java.lang.String findLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader._findLibrary13047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._findLibrary13047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DexClassLoader13048;
		public DexClassLoader(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.ClassLoader arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexClassLoader.staticClass, global::dalvik.system.DexClassLoader._DexClassLoader13048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.DexClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/DexClassLoader"));
			global::dalvik.system.DexClassLoader._getPackage13044 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::dalvik.system.DexClassLoader._findClass13045 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::dalvik.system.DexClassLoader._findResource13046 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::dalvik.system.DexClassLoader._findLibrary13047 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::dalvik.system.DexClassLoader._DexClassLoader13048 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V");
		}
	}
}
