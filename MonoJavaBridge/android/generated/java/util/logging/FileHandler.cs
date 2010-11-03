namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.FileHandler.staticClass, "close", "()V", ref global::java.util.logging.FileHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.FileHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.FileHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FileHandler(java.lang.String arg0, int arg1, int arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._m2.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._m2 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public FileHandler(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._m3.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._m3 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public FileHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._m4.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._m4 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public FileHandler(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._m5.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._m5 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public FileHandler(java.lang.String arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.FileHandler._m6.native == global::System.IntPtr.Zero)
				global::java.util.logging.FileHandler._m6 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static FileHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.FileHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/FileHandler"));
		}
	}
}
