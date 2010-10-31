namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchDex : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TouchDex(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void main(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TouchDex._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.TouchDex._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "main", "([Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int start(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TouchDex._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.TouchDex._m1 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "start", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public TouchDex() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TouchDex._m2.native == global::System.IntPtr.Zero)
				global::dalvik.system.TouchDex._m2 = @__env.GetMethodIDNoThrow(global::dalvik.system.TouchDex.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.TouchDex.staticClass, global::dalvik.system.TouchDex._m2);
			Init(@__env, handle);
		}
		static TouchDex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.TouchDex.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/TouchDex"));
		}
	}
}
