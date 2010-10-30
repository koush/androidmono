namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringBuilderPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringBuilderPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.StringBuilderPrinter.staticClass, "println", "(Ljava/lang/String;)V", ref global::android.util.StringBuilderPrinter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StringBuilderPrinter(java.lang.StringBuilder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StringBuilderPrinter._m1.native == global::System.IntPtr.Zero)
				global::android.util.StringBuilderPrinter._m1 = @__env.GetMethodIDNoThrow(global::android.util.StringBuilderPrinter.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StringBuilderPrinter.staticClass, global::android.util.StringBuilderPrinter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBuilderPrinter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StringBuilderPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StringBuilderPrinter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
