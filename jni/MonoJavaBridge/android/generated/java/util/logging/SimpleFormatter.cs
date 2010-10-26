namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleFormatter : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleFormatter()
		{
			InitJNI();
		}
		protected SimpleFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format28097;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.SimpleFormatter._format28097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.SimpleFormatter.staticClass, global::java.util.logging.SimpleFormatter._format28097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SimpleFormatter28098;
		public SimpleFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SimpleFormatter.staticClass, global::java.util.logging.SimpleFormatter._SimpleFormatter28098);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.SimpleFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/SimpleFormatter"));
			global::java.util.logging.SimpleFormatter._format28097 = @__env.GetMethodIDNoThrow(global::java.util.logging.SimpleFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.SimpleFormatter._SimpleFormatter28098 = @__env.GetMethodIDNoThrow(global::java.util.logging.SimpleFormatter.staticClass, "<init>", "()V");
		}
	}
}
