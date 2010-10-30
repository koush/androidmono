namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMStack : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VMStack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.Class[] getClasses(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMStack._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMStack._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getClasses", "(IZ)[Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class[];
		}
		public static global::java.lang.ClassLoader CallingClassLoader
		{
			get
			{
				return getCallingClassLoader();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.ClassLoader getCallingClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMStack._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMStack._m1 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getCallingClassLoader", "()Ljava/lang/ClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._m1)) as java.lang.ClassLoader;
		}
		public static global::java.lang.ClassLoader CallingClassLoader2
		{
			get
			{
				return getCallingClassLoader2();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.ClassLoader getCallingClassLoader2()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMStack._m2.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMStack._m2 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getCallingClassLoader2", "()Ljava/lang/ClassLoader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._m2)) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.StackTraceElement[] getThreadStackTrace(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMStack._m3.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMStack._m3 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "getThreadStackTrace", "(Ljava/lang/Thread;)[Ljava/lang/StackTraceElement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallStaticObjectMethod(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.StackTraceElement[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public VMStack() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMStack._m4.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMStack._m4 = @__env.GetMethodIDNoThrow(global::dalvik.system.VMStack.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.VMStack.staticClass, global::dalvik.system.VMStack._m4);
			Init(@__env, handle);
		}
		static VMStack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMStack.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMStack"));
		}
		internal static void InitJNI()
		{
		}
	}
}
