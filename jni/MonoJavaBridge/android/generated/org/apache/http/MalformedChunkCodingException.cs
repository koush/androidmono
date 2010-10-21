namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedChunkCodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MalformedChunkCodingException()
		{
			InitJNI();
		}
		protected MalformedChunkCodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChunkCodingException31615;
		public MalformedChunkCodingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MalformedChunkCodingException.staticClass, global::org.apache.http.MalformedChunkCodingException._MalformedChunkCodingException31615);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChunkCodingException31616;
		public MalformedChunkCodingException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.MalformedChunkCodingException.staticClass, global::org.apache.http.MalformedChunkCodingException._MalformedChunkCodingException31616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.MalformedChunkCodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/MalformedChunkCodingException"));
			global::org.apache.http.MalformedChunkCodingException._MalformedChunkCodingException31615 = @__env.GetMethodIDNoThrow(global::org.apache.http.MalformedChunkCodingException.staticClass, "<init>", "()V");
			global::org.apache.http.MalformedChunkCodingException._MalformedChunkCodingException31616 = @__env.GetMethodIDNoThrow(global::org.apache.http.MalformedChunkCodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
