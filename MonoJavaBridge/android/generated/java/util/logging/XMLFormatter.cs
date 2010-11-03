namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLFormatter : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XMLFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.XMLFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", ref global::java.util.logging.XMLFormatter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String getHead(java.util.logging.Handler arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.XMLFormatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", ref global::java.util.logging.XMLFormatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getTail(java.util.logging.Handler arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.XMLFormatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", ref global::java.util.logging.XMLFormatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public XMLFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.XMLFormatter._m3.native == global::System.IntPtr.Zero)
				global::java.util.logging.XMLFormatter._m3 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._m3);
			Init(@__env, handle);
		}
		static XMLFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.XMLFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/XMLFormatter"));
		}
	}
}
