namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedHttpVersionException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedHttpVersionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnsupportedHttpVersionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.UnsupportedHttpVersionException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.UnsupportedHttpVersionException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnsupportedHttpVersionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.UnsupportedHttpVersionException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.UnsupportedHttpVersionException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.UnsupportedHttpVersionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.UnsupportedHttpVersionException.staticClass, global::org.apache.http.UnsupportedHttpVersionException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedHttpVersionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.UnsupportedHttpVersionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/UnsupportedHttpVersionException"));
		}
	}
}
