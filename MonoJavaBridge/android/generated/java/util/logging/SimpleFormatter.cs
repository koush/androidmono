namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleFormatter : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.SimpleFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", ref global::java.util.logging.SimpleFormatter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SimpleFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.SimpleFormatter._m1.native == global::System.IntPtr.Zero)
				global::java.util.logging.SimpleFormatter._m1 = @__env.GetMethodIDNoThrow(global::java.util.logging.SimpleFormatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SimpleFormatter.staticClass, global::java.util.logging.SimpleFormatter._m1);
			Init(@__env, handle);
		}
		static SimpleFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.SimpleFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/SimpleFormatter"));
		}
	}
}
