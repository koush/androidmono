namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolException : org.apache.http.HttpException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ProtocolException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ProtocolException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.ProtocolException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ProtocolException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ProtocolException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.ProtocolException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ProtocolException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ProtocolException._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.ProtocolException._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolException.staticClass, global::org.apache.http.ProtocolException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ProtocolException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ProtocolException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
