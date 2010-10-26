namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Zygote : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Zygote()
		{
			InitJNI();
		}
		protected Zygote(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fork18675;
		public static int fork() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._fork18675);
		}
		internal static global::MonoJavaBridge.MethodId _forkAndSpecialize18676;
		public static int forkAndSpecialize(int arg0, int arg1, int[] arg2, int arg3, int[][] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._forkAndSpecialize18676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _forkAndSpecialize18677;
		public static int forkAndSpecialize(int arg0, int arg1, int[] arg2, bool arg3, int[][] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._forkAndSpecialize18677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _forkSystemServer18678;
		public static int forkSystemServer(int arg0, int arg1, int[] arg2, int arg3, int[][] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._forkSystemServer18678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _forkSystemServer18679;
		public static int forkSystemServer(int arg0, int arg1, int[] arg2, bool arg3, int[][] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.Zygote.staticClass, global::dalvik.system.Zygote._forkSystemServer18679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.Zygote.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/Zygote"));
			global::dalvik.system.Zygote._fork18675 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "fork", "()I");
			global::dalvik.system.Zygote._forkAndSpecialize18676 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkAndSpecialize", "(II[II[[I)I");
			global::dalvik.system.Zygote._forkAndSpecialize18677 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkAndSpecialize", "(II[IZ[[I)I");
			global::dalvik.system.Zygote._forkSystemServer18678 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkSystemServer", "(II[II[[I)I");
			global::dalvik.system.Zygote._forkSystemServer18679 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.Zygote.staticClass, "forkSystemServer", "(II[IZ[[I)I");
		}
	}
}
