namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchDex : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TouchDex(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _main18612;
		public static void main(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._main18612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start18613;
		public static int start(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._start18613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TouchDex18614;
		public TouchDex() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._TouchDex18614);
			Init(@__env, handle);
		}
		static TouchDex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.TouchDex.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/TouchDex"));
			global::dalvik.system.TouchDex._main18612 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "main", "([Ljava/lang/String;)V");
			global::dalvik.system.TouchDex._start18613 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "start", "(Ljava/lang/String;)I");
			global::dalvik.system.TouchDex._TouchDex18614 = @__env.GetMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
