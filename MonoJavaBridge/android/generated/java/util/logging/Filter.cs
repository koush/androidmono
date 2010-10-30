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
		internal static global::MonoJavaBridge.MethodId _isLoggable27952;
		bool java.util.logging.Filter.isLoggable(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Filter_._isLoggable27952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Filter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Filter"));
			global::java.util.logging.Filter_._isLoggable27952 = @__env.GetMethodIDNoThrow(global::java.util.logging.Filter_.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
