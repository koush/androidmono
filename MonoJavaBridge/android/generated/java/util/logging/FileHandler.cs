namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close27945;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.FileHandler.staticClass, "close", "()V", ref global::java.util.logging.FileHandler._close27945);
		}
		internal static global::MonoJavaBridge.MethodId _publish27946;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.FileHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.FileHandler._publish27946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler27947;
		public FileHandler(java.lang.String arg0, int arg1, int arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._FileHandler27947.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._FileHandler27947 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler27947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler27948;
		public FileHandler(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._FileHandler27948.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._FileHandler27948 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler27948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler27949;
		public FileHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._FileHandler27949.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._FileHandler27949 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler27949);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler27950;
		public FileHandler(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._FileHandler27950.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._FileHandler27950 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler27950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler27951;
		public FileHandler(java.lang.String arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._FileHandler27951.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._FileHandler27951 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler27951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static FileHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.FileHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/FileHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
