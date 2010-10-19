namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ExceptionUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExceptionUtils()
		{
			InitJNI();
		}
		internal ExceptionUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initCause27211;
		public static void initCause(java.lang.Throwable arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.util.ExceptionUtils.staticClass, global::org.apache.http.util.ExceptionUtils._initCause27211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.ExceptionUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/ExceptionUtils"));
			global::org.apache.http.util.ExceptionUtils._initCause27211 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.ExceptionUtils.staticClass, "initCause", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V");
		}
	}
}
