namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.ExecutionContext_))]
	public partial interface ExecutionContext  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.ExecutionContext))]
	internal sealed partial class ExecutionContext_ : java.lang.Object, ExecutionContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExecutionContext_()
		{
			InitJNI();
		}
		internal ExecutionContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ExecutionContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ExecutionContext"));
		}
	}
}
