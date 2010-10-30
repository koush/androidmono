namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DexFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DexFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _loadClass18589;
		public global::java.lang.Class loadClass(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.system.DexFile.staticClass, "loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", ref global::dalvik.system.DexFile._loadClass18589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName18590;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.system.DexFile.staticClass, "getName", "()Ljava/lang/String;", ref global::dalvik.system.DexFile._getName18590) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close18591;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::dalvik.system.DexFile.staticClass, "close", "()V", ref global::dalvik.system.DexFile._close18591);
		}
		internal static global::MonoJavaBridge.MethodId _entries18592;
		public global::java.util.Enumeration entries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::dalvik.system.DexFile.staticClass, "entries", "()Ljava/util/Enumeration;", ref global::dalvik.system.DexFile._entries18592) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _loadDex18593;
		public static global::dalvik.system.DexFile loadDex(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.DexFile._loadDex18593.native == global::System.IntPtr.Zero)
				global::dalvik.system.DexFile._loadDex18593 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "loadDex", "(Ljava/lang/String;Ljava/lang/String;I)Ldalvik/system/DexFile;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<dalvik.system.DexFile>(@__env.CallStaticObjectMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._loadDex18593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as dalvik.system.DexFile;
		}
		internal static global::MonoJavaBridge.MethodId _isDexOptNeeded18594;
		public static bool isDexOptNeeded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.DexFile._isDexOptNeeded18594.native == global::System.IntPtr.Zero)
				global::dalvik.system.DexFile._isDexOptNeeded18594 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "isDexOptNeeded", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._isDexOptNeeded18594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DexFile18595;
		public DexFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.DexFile._DexFile18595.native == global::System.IntPtr.Zero)
				global::dalvik.system.DexFile._DexFile18595 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile18595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DexFile18596;
		public DexFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.DexFile._DexFile18596.native == global::System.IntPtr.Zero)
				global::dalvik.system.DexFile._DexFile18596 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile18596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DexFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.DexFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/DexFile"));
		}
		internal static void InitJNI()
		{
		}
	}
}
