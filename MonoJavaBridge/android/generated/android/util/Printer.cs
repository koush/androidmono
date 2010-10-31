namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.Printer_))]
	public partial interface Printer  : global::MonoJavaBridge.IJavaObject 
	{
		void println(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.util.Printer))]
	internal sealed partial class Printer_ : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Printer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.util.Printer.println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Printer_.staticClass, "println", "(Ljava/lang/String;)V", ref global::android.util.Printer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Printer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Printer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Printer"));
		}
	}

	public delegate void PrinterDelegate(java.lang.String arg0);

	internal partial class PrinterDelegateWrapper : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrinterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public PrinterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.PrinterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.util.PrinterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.util.PrinterDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.PrinterDelegateWrapper.staticClass, global::android.util.PrinterDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static PrinterDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.PrinterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/PrinterDelegateWrapper"));
		}
	}
	internal partial class PrinterDelegateWrapper
	{
		private PrinterDelegate myDelegate;
		public void println(java.lang.String arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator PrinterDelegateWrapper(PrinterDelegate d)
		{
			global::android.util.PrinterDelegateWrapper ret = new global::android.util.PrinterDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
