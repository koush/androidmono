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
		internal static global::MonoJavaBridge.MethodId _format27993;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._format27993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._format27993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHead27994;
		public override global::java.lang.String getHead(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getHead27994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getHead27994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTail27995;
		public override global::java.lang.String getTail(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter._getTail27995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._getTail27995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _XMLFormatter27996;
		public XMLFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.XMLFormatter.staticClass, global::java.util.logging.XMLFormatter._XMLFormatter27996);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.XMLFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/XMLFormatter"));
			global::java.util.logging.XMLFormatter._format27993 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getHead27994 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._getTail27995 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.XMLFormatter._XMLFormatter27996 = @__env.GetMethodIDNoThrow(global::java.util.logging.XMLFormatter.staticClass, "<init>", "()V");
		}
	}
}
