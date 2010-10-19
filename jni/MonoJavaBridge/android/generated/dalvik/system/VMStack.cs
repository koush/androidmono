namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMStack : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VMStack()
		{
			InitJNI();
		}
		internal VMStack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getClasses13105;
		public static global::java.lang.Class[] getClasses(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._getClasses13105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class[];
		}
		public static global::java.lang.ClassLoader CallingClassLoader
		{
			get
			{
				return getCallingClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingClassLoader13106;
		public static global::java.lang.ClassLoader getCallingClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._getCallingClassLoader13106)) as java.lang.ClassLoader;
		}
		public static global::java.lang.ClassLoader CallingClassLoader2
		{
			get
			{
				return getCallingClassLoader2();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingClassLoader213107;
		public static global::java.lang.ClassLoader getCallingClassLoader2() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._getCallingClassLoader213107)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getThreadStackTrace13108;
		public static global::java.lang.StackTraceElement[] getThreadStackTrace(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._getThreadStackTrace13108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _VMStack13109;
		public VMStack()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._VMStack13109);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMStack.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMStack"));
			global::dalvik.system.VMStack._getClasses13105 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getClasses", "(IZ)[Ljava/lang/Class;");
			global::dalvik.system.VMStack._getCallingClassLoader13106 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getCallingClassLoader", "()Ljava/lang/ClassLoader;");
			global::dalvik.system.VMStack._getCallingClassLoader213107 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getCallingClassLoader2", "()Ljava/lang/ClassLoader;");
			global::dalvik.system.VMStack._getThreadStackTrace13108 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getThreadStackTrace", "(Ljava/lang/Thread;)[Ljava/lang/StackTraceElement;");
			global::dalvik.system.VMStack._VMStack13109 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "<init>", "()V");
		}
	}
}
