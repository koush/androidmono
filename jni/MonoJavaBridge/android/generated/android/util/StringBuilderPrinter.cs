namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringBuilderPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringBuilderPrinter()
		{
			InitJNI();
		}
		protected StringBuilderPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13820;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.StringBuilderPrinter._println13820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.StringBuilderPrinter.staticClass, global::android.util.StringBuilderPrinter._println13820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StringBuilderPrinter13821;
		public StringBuilderPrinter(java.lang.StringBuilder arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StringBuilderPrinter.staticClass, global::android.util.StringBuilderPrinter._StringBuilderPrinter13821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StringBuilderPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StringBuilderPrinter"));
			global::android.util.StringBuilderPrinter._println13820 = @__env.GetMethodIDNoThrow(global::android.util.StringBuilderPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::android.util.StringBuilderPrinter._StringBuilderPrinter13821 = @__env.GetMethodIDNoThrow(global::android.util.StringBuilderPrinter.staticClass, "<init>", "(Ljava/lang/StringBuilder;)V");
		}
	}
}
