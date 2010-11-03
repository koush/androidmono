namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.logging.Formatter_))]
	public abstract partial class Formatter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String format(java.util.logging.LogRecord arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String formatMessage(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Formatter.staticClass, "formatMessage", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", ref global::java.util.logging.Formatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getHead(java.util.logging.Handler arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Formatter.staticClass, "getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", ref global::java.util.logging.Formatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getTail(java.util.logging.Handler arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Formatter.staticClass, "getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", ref global::java.util.logging.Formatter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected Formatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Formatter._m4.native == global::System.IntPtr.Zero)
				global::java.util.logging.Formatter._m4 = @__env.GetMethodIDNoThrow(global::java.util.logging.Formatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Formatter.staticClass, global::java.util.logging.Formatter._m4);
			Init(@__env, handle);
		}
		static Formatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Formatter"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Formatter))]
	internal sealed partial class Formatter_ : java.util.logging.Formatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Formatter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String format(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Formatter_.staticClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", ref global::java.util.logging.Formatter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static Formatter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Formatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Formatter"));
		}
	}
}
