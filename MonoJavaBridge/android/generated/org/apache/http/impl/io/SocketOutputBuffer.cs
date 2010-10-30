namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketOutputBuffer : org.apache.http.impl.io.AbstractSessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SocketOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.SocketOutputBuffer._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.SocketOutputBuffer._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.SocketOutputBuffer.staticClass, "<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.SocketOutputBuffer.staticClass, global::org.apache.http.impl.io.SocketOutputBuffer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SocketOutputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.SocketOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/SocketOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
