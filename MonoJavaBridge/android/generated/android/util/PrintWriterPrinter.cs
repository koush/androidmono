namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintWriterPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrintWriterPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.PrintWriterPrinter.staticClass, "println", "(Ljava/lang/String;)V", ref global::android.util.PrintWriterPrinter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public PrintWriterPrinter(java.io.PrintWriter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.PrintWriterPrinter._m1.native == global::System.IntPtr.Zero)
				global::android.util.PrintWriterPrinter._m1 = @__env.GetMethodIDNoThrow(global::android.util.PrintWriterPrinter.staticClass, "<init>", "(Ljava/io/PrintWriter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.PrintWriterPrinter.staticClass, global::android.util.PrintWriterPrinter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PrintWriterPrinter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.PrintWriterPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/PrintWriterPrinter"));
		}
	}
}
