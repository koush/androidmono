namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PathClassLoader()
		{
			InitJNI();
		}
		protected PathClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13057;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._toString13057)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._toString13057)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage13058;
		protected override global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._getPackage13058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._getPackage13058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _findClass13059;
		protected override global::java.lang.Class findClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._findClass13059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._findClass13059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _findResource13060;
		protected override global::java.net.URL findResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._findResource13060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._findResource13060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _findResources13061;
		protected override global::java.util.Enumeration findResources(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._findResources13061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._findResources13061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _findLibrary13062;
		protected override global::java.lang.String findLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader._findLibrary13062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._findLibrary13062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PathClassLoader13063;
		public PathClassLoader(java.lang.String arg0, java.lang.ClassLoader arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._PathClassLoader13063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathClassLoader13064;
		public PathClassLoader(java.lang.String arg0, java.lang.String arg1, java.lang.ClassLoader arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PathClassLoader.staticClass, global::dalvik.system.PathClassLoader._PathClassLoader13064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.PathClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/PathClassLoader"));
			global::dalvik.system.PathClassLoader._toString13057 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "toString", "()Ljava/lang/String;");
			global::dalvik.system.PathClassLoader._getPackage13058 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::dalvik.system.PathClassLoader._findClass13059 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::dalvik.system.PathClassLoader._findResource13060 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "findResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::dalvik.system.PathClassLoader._findResources13061 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::dalvik.system.PathClassLoader._findLibrary13062 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "findLibrary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::dalvik.system.PathClassLoader._PathClassLoader13063 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::dalvik.system.PathClassLoader._PathClassLoader13064 = @__env.GetMethodIDNoThrow(global::dalvik.system.PathClassLoader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)V");
		}
	}
}
