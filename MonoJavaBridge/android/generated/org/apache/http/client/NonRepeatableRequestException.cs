namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonRepeatableRequestException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NonRepeatableRequestException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NonRepeatableRequestException31894;
		public NonRepeatableRequestException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31894.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31894 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.NonRepeatableRequestException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.NonRepeatableRequestException.staticClass, global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31894);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NonRepeatableRequestException31895;
		public NonRepeatableRequestException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31895.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31895 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.NonRepeatableRequestException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.NonRepeatableRequestException.staticClass, global::org.apache.http.client.NonRepeatableRequestException._NonRepeatableRequestException31895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NonRepeatableRequestException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.NonRepeatableRequestException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/NonRepeatableRequestException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
