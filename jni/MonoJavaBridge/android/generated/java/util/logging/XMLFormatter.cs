namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLFormatter : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLFormatter()
		{
			InitJNI();
		}
		protected XMLFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format22130;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._format22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._format22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHead22131;
		public override global::java.lang.String getHead(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getHead22131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getHead22131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTail22132;
		public override global::java.lang.String getTail(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getTail22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getTail22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _XMLFormatter22133;
		public XMLFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._XMLFormatter22133);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.XMLFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/XMLFormatter"));
			global::java.util.logging.XMLFormatter._format22130 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getHead22131 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getTail22132 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._XMLFormatter22133 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "<init>", "()V");
		}
	}
}
