namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TemporaryDirectory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TemporaryDirectory()
		{
			InitJNI();
		}
		protected TemporaryDirectory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setUpDirectory18491;
		public static void setUpDirectory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._setUpDirectory18491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUpDirectory18492;
		public static void setUpDirectory(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._setUpDirectory18492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TemporaryDirectory18493;
		public TemporaryDirectory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.TemporaryDirectory.staticClass, global::dalvik.system.TemporaryDirectory._TemporaryDirectory18493);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.TemporaryDirectory.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/TemporaryDirectory"));
			global::dalvik.system.TemporaryDirectory._setUpDirectory18491 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "setUpDirectory", "(Ljava/lang/String;)V");
			global::dalvik.system.TemporaryDirectory._setUpDirectory18492 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "setUpDirectory", "(Ljava/io/File;)V");
			global::dalvik.system.TemporaryDirectory._TemporaryDirectory18493 = @__env.GetMethodIDNoThrow(global::dalvik.system.TemporaryDirectory.staticClass, "<init>", "()V");
		}
	}
}
