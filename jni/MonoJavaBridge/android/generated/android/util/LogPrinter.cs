namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LogPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13796;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.LogPrinter._println13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.LogPrinter.staticClass, global::android.util.LogPrinter._println13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LogPrinter13797;
		public LogPrinter(int arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.LogPrinter.staticClass, global::android.util.LogPrinter._LogPrinter13797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LogPrinter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.LogPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/LogPrinter"));
			global::android.util.LogPrinter._println13796 = @__env.GetMethodIDNoThrow(global::android.util.LogPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::android.util.LogPrinter._LogPrinter13797 = @__env.GetMethodIDNoThrow(global::android.util.LogPrinter.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
