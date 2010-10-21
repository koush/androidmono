namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DexFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DexFile()
		{
			InitJNI();
		}
		internal DexFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _loadClass18471;
		public global::java.lang.Class loadClass(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._loadClass18471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._loadClass18471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName18472;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._getName18472)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._getName18472)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close18473;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.DexFile._close18473);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._close18473);
		}
		internal static global::MonoJavaBridge.MethodId _entries18474;
		public global::java.util.Enumeration entries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._entries18474)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._entries18474)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _loadDex18475;
		public static global::dalvik.system.DexFile loadDex(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._loadDex18475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as dalvik.system.DexFile;
		}
		internal static global::MonoJavaBridge.MethodId _isDexOptNeeded18476;
		public static bool isDexOptNeeded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._isDexOptNeeded18476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DexFile18477;
		public DexFile(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile18477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DexFile18478;
		public DexFile(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile18478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.DexFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/DexFile"));
			global::dalvik.system.DexFile._loadClass18471 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;");
			global::dalvik.system.DexFile._getName18472 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "getName", "()Ljava/lang/String;");
			global::dalvik.system.DexFile._close18473 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "close", "()V");
			global::dalvik.system.DexFile._entries18474 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::dalvik.system.DexFile._loadDex18475 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "loadDex", "(Ljava/lang/String;Ljava/lang/String;I)Ldalvik/system/DexFile;");
			global::dalvik.system.DexFile._isDexOptNeeded18476 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "isDexOptNeeded", "(Ljava/lang/String;)Z");
			global::dalvik.system.DexFile._DexFile18477 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::dalvik.system.DexFile._DexFile18478 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/io/File;)V");
		}
	}
}
