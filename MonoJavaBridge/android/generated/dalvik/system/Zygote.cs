namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Zygote : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Zygote(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int fork()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.Zygote._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.Zygote._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "fork", "()I");
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int forkAndSpecialize(int arg0, int arg1, int[] arg2, int arg3, int[][] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.Zygote._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.Zygote._m1 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkAndSpecialize", "(II[II[[I)I");
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int forkAndSpecialize(int arg0, int arg1, int[] arg2, bool arg3, int[][] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.Zygote._m2.native == global::System.IntPtr.Zero)
				global::dalvik.system.Zygote._m2 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkAndSpecialize", "(II[IZ[[I)I");
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int forkSystemServer(int arg0, int arg1, int[] arg2, int arg3, int[][] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.Zygote._m3.native == global::System.IntPtr.Zero)
				global::dalvik.system.Zygote._m3 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkSystemServer", "(II[II[[I)I");
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int forkSystemServer(int arg0, int arg1, int[] arg2, bool arg3, int[][] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.Zygote._m4.native == global::System.IntPtr.Zero)
				global::dalvik.system.Zygote._m4 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkSystemServer", "(II[IZ[[I)I");
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public static int DEBUG_ENABLE_DEBUGGER
		{
			get
			{
				return 1;
			}
		}
		public static int DEBUG_ENABLE_CHECKJNI
		{
			get
			{
				return 2;
			}
		}
		public static int DEBUG_ENABLE_ASSERT
		{
			get
			{
				return 4;
			}
		}
		public static int DEBUG_ENABLE_SAFEMODE
		{
			get
			{
				return 8;
			}
		}
		static Zygote()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.Zygote.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/Zygote"));
		}
		internal static void InitJNI()
		{
		}
	}
}
