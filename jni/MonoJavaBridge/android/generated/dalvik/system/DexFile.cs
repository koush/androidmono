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
		internal static global::MonoJavaBridge.MethodId _loadClass13049;
		public global::java.lang.Class loadClass(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._loadClass13049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._loadClass13049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName13050;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._getName13050)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._getName13050)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13051;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::dalvik.system.DexFile._close13051);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._close13051);
		}
		internal static global::MonoJavaBridge.MethodId _entries13052;
		public global::java.util.Enumeration entries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.system.DexFile._entries13052)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._entries13052)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _loadDex13053;
		public static global::dalvik.system.DexFile loadDex(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._loadDex13053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as dalvik.system.DexFile;
		}
		internal static global::MonoJavaBridge.MethodId _isDexOptNeeded13054;
		public static bool isDexOptNeeded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._isDexOptNeeded13054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DexFile13055;
		public DexFile(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile13055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DexFile13056;
		public DexFile(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.DexFile.staticClass, global::dalvik.system.DexFile._DexFile13056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.DexFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/DexFile"));
			global::dalvik.system.DexFile._loadClass13049 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;");
			global::dalvik.system.DexFile._getName13050 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "getName", "()Ljava/lang/String;");
			global::dalvik.system.DexFile._close13051 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "close", "()V");
			global::dalvik.system.DexFile._entries13052 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::dalvik.system.DexFile._loadDex13053 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "loadDex", "(Ljava/lang/String;Ljava/lang/String;I)Ldalvik/system/DexFile;");
			global::dalvik.system.DexFile._isDexOptNeeded13054 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "isDexOptNeeded", "(Ljava/lang/String;)Z");
			global::dalvik.system.DexFile._DexFile13055 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::dalvik.system.DexFile._DexFile13056 = @__env.GetMethodIDNoThrow(global::dalvik.system.DexFile.staticClass, "<init>", "(Ljava/io/File;)V");
		}
	}
}
