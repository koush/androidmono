namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ExceptionUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ExceptionUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initCause34014;
		public static void initCause(java.lang.Throwable arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.ExceptionUtils._initCause34014.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.ExceptionUtils._initCause34014 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.ExceptionUtils.staticClass, "initCause", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V");
			@__env.CallStaticVoidMethod(org.apache.http.util.ExceptionUtils.staticClass, global::org.apache.http.util.ExceptionUtils._initCause34014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ExceptionUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.ExceptionUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/ExceptionUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
