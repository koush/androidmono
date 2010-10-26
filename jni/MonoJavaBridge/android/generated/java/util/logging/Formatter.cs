namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.logging.Formatter_))]
	public abstract partial class Formatter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Formatter()
		{
			InitJNI();
		}
		protected Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format27952;
		public abstract global::java.lang.String format(java.util.logging.LogRecord arg0);
		internal static global::MonoJavaBridge.MethodId _formatMessage27953;
		public virtual global::java.lang.String formatMessage(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Formatter._formatMessage27953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Formatter.staticClass, global::java.util.logging.Formatter._formatMessage27953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHead27954;
		public virtual global::java.lang.String getHead(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Formatter._getHead27954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Formatter.staticClass, global::java.util.logging.Formatter._getHead27954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTail27955;
		public virtual global::java.lang.String getTail(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Formatter._getTail27955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Formatter.staticClass, global::java.util.logging.Formatter._getTail27955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Formatter27956;
		protected Formatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Formatter.staticClass, global::java.util.logging.Formatter._Formatter27956);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Formatter"));
			global::java.util.logging.Formatter._format27952 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.Formatter._formatMessage27953 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "formatMessage", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			global::java.util.logging.Formatter._getHead27954 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.Formatter._getTail27955 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;");
			global::java.util.logging.Formatter._Formatter27956 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Formatter))]
	internal sealed partial class Formatter_ : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Formatter_()
		{
			InitJNI();
		}
		internal Formatter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format27957;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Formatter_._format27957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Formatter_.staticClass, global::java.util.logging.Formatter_._format27957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Formatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Formatter"));
			global::java.util.logging.Formatter_._format27957 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter_.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
		}
	}
}
