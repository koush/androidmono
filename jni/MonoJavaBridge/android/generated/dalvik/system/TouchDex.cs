namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchDex : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TouchDex()
		{
			InitJNI();
		}
		protected TouchDex(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _main18494;
		public static void main(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._main18494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start18495;
		public static int start(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._start18495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TouchDex18496;
		public TouchDex()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._TouchDex18496);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.TouchDex.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/TouchDex"));
			global::dalvik.system.TouchDex._main18494 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "main", "([Ljava/lang/String;)V");
			global::dalvik.system.TouchDex._start18495 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "start", "(Ljava/lang/String;)I");
			global::dalvik.system.TouchDex._TouchDex18496 = @__env.GetMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "<init>", "()V");
		}
	}
}
