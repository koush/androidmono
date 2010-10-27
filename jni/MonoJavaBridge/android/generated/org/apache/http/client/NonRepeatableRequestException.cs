namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonRepeatableRequestException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NonRepeatableRequestException()
		{
			InitJNI();
		}
		protected NonRepeatableRequestException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NonRepeatableRequestException31893;
		public NonRepeatableRequestException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.NonRepeatableRequestException.staticClass, global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31893);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NonRepeatableRequestException31894;
		public NonRepeatableRequestException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.NonRepeatableRequestException.staticClass, global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.NonRepeatableRequestException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/NonRepeatableRequestException"));
			global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31893 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.NonRepeatableRequestException.staticClass, "<init>", "()V");
			global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31894 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.NonRepeatableRequestException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
