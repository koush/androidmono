namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLFormatter : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XMLFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format28112;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._format28112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._format28112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHead28113;
		public override global::java.lang.String getHead(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getHead28113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getHead28113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTail28114;
		public override global::java.lang.String getTail(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getTail28114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getTail28114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _XMLFormatter28115;
		public XMLFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._XMLFormatter28115);
			Init(@__env, handle);
		}
		static XMLFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.XMLFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/XMLFormatter"));
			global::java.util.logging.XMLFormatter._format28112 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getHead28113 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getTail28114 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._XMLFormatter28115 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
