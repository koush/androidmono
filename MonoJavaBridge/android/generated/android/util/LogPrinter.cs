namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LogPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.LogPrinter.staticClass, "println", "(Ljava/lang/String;)V", ref global::android.util.LogPrinter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public LogPrinter(int arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.LogPrinter._m1.native == global::System.IntPtr.Zero)
				global::android.util.LogPrinter._m1 = @__env.GetMethodIDNoThrow(global::android.util.LogPrinter.staticClass, "<init>", "(ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.LogPrinter.staticClass, global::android.util.LogPrinter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LogPrinter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.LogPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/LogPrinter"));
		}
	}
}
