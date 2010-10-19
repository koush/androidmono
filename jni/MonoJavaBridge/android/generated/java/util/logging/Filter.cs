namespace java.util.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.logging.Filter_))]
	public interface Filter  : global::MonoJavaBridge.IJavaObject 
	{
		bool isLoggable(java.util.logging.LogRecord arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Filter))]
	public sealed partial class Filter_ : java.lang.Object, Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filter_()
		{
			InitJNI();
		}
		internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable21972;
		 bool java.util.logging.Filter.isLoggable(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Filter_._isLoggable21972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Filter_.staticClass, global::java.util.logging.Filter_._isLoggable21972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Filter"));
			global::java.util.logging.Filter_._isLoggable21972 = @__env.GetMethodIDNoThrow(global::java.util.logging.Filter_.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
		}
	}
}
