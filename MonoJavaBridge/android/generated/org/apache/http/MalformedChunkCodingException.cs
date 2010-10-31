namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedChunkCodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedChunkCodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public MalformedChunkCodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.MalformedChunkCodingException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.MalformedChunkCodingException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.MalformedChunkCodingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MalformedChunkCodingException.staticClass, global::org.apache.http.MalformedChunkCodingException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MalformedChunkCodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.MalformedChunkCodingException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.MalformedChunkCodingException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.MalformedChunkCodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MalformedChunkCodingException.staticClass, global::org.apache.http.MalformedChunkCodingException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MalformedChunkCodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.MalformedChunkCodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/MalformedChunkCodingException"));
		}
	}
}
