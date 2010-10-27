namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientProtocolException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientProtocolException()
		{
			InitJNI();
		}
		protected ClientProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClientProtocolException31869;
		public ClientProtocolException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._ClientProtocolException31869);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientProtocolException31870;
		public ClientProtocolException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._ClientProtocolException31870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientProtocolException31871;
		public ClientProtocolException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._ClientProtocolException31871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientProtocolException31872;
		public ClientProtocolException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._ClientProtocolException31872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.ClientProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/ClientProtocolException"));
			global::org.apache.http.client.ClientProtocolException._ClientProtocolException31869 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "()V");
			global::org.apache.http.client.ClientProtocolException._ClientProtocolException31870 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.client.ClientProtocolException._ClientProtocolException31871 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::org.apache.http.client.ClientProtocolException._ClientProtocolException31872 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
