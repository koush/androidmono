namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTLMEngineException : org.apache.http.auth.AuthenticationException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NTLMEngineException()
		{
			InitJNI();
		}
		protected NTLMEngineException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NTLMEngineException32738;
		public NTLMEngineException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMEngineException.staticClass, global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32738);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NTLMEngineException32739;
		public NTLMEngineException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMEngineException.staticClass, global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NTLMEngineException32740;
		public NTLMEngineException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMEngineException.staticClass, global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMEngineException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMEngineException"));
			global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32738 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMEngineException.staticClass, "<init>", "()V");
			global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32739 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMEngineException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.auth.NTLMEngineException._NTLMEngineException32740 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMEngineException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
