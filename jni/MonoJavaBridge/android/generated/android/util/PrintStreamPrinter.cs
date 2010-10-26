namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintStreamPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrintStreamPrinter()
		{
			InitJNI();
		}
		protected PrintStreamPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13830;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.PrintStreamPrinter._println13830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._println13830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PrintStreamPrinter13831;
		public PrintStreamPrinter(java.io.PrintStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._PrintStreamPrinter13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.PrintStreamPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/PrintStreamPrinter"));
			global::android.util.PrintStreamPrinter._println13830 = @__env.GetMethodIDNoThrow(global::android.util.PrintStreamPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::android.util.PrintStreamPrinter._PrintStreamPrinter13831 = @__env.GetMethodIDNoThrow(global::android.util.PrintStreamPrinter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
		}
	}
}
