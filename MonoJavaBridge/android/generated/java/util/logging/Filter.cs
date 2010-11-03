namespace java.util.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.logging.Filter_))]
	public partial interface Filter  : global::MonoJavaBridge.IJavaObject 
	{
		bool isLoggable(java.util.logging.LogRecord arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Filter))]
	internal sealed partial class Filter_ : java.lang.Object, Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.logging.Filter.isLoggable(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Filter_.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z", ref global::java.util.logging.Filter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Filter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Filter"));
		}
	}
}
