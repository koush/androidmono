namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TemporaryDirectory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TemporaryDirectory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setUpDirectory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TemporaryDirectory._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.TemporaryDirectory._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "setUpDirectory", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setUpDirectory(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TemporaryDirectory._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.TemporaryDirectory._m1 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "setUpDirectory", "(Ljava/io/File;)V");
			@__env.CallStaticVoidMethod(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public TemporaryDirectory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.TemporaryDirectory._m2.native == global::System.IntPtr.Zero)
				global::dalvik.system.TemporaryDirectory._m2 = @__env.GetMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._m2);
			Init(@__env, handle);
		}
		static TemporaryDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.TemporaryDirectory.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/TemporaryDirectory"));
		}
	}
}
