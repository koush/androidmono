namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketOutputBuffer : org.apache.http.impl.io.AbstractSessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketOutputBuffer()
		{
			InitJNI();
		}
		protected SocketOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SocketOutputBuffer33465;
		public SocketOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.SocketOutputBuffer.staticClass, global::org.apache.http.impl.io.SocketOutputBuffer._SocketOutputBuffer33465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.SocketOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/SocketOutputBuffer"));
			global::org.apache.http.impl.io.SocketOutputBuffer._SocketOutputBuffer33465 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.SocketOutputBuffer.staticClass, "<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V");
		}
	}
}
