namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientProtocolException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClientProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ClientProtocolException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.ClientProtocolException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.ClientProtocolException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ClientProtocolException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.ClientProtocolException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.ClientProtocolException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ClientProtocolException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.ClientProtocolException._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.ClientProtocolException._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ClientProtocolException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.ClientProtocolException._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.ClientProtocolException._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.ClientProtocolException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.ClientProtocolException.staticClass, global::org.apache.http.client.ClientProtocolException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ClientProtocolException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.ClientProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/ClientProtocolException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
