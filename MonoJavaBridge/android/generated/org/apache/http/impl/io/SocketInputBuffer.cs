namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketInputBuffer : org.apache.http.impl.io.AbstractSessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33464;
		public override bool isDataAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.io.SocketInputBuffer.staticClass, "isDataAvailable", "(I)Z", ref global::org.apache.http.impl.io.SocketInputBuffer._isDataAvailable33464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SocketInputBuffer33465;
		public SocketInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.SocketInputBuffer._SocketInputBuffer33465.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.SocketInputBuffer._SocketInputBuffer33465 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.SocketInputBuffer.staticClass, "<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.SocketInputBuffer.staticClass, global::org.apache.http.impl.io.SocketInputBuffer._SocketInputBuffer33465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SocketInputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.SocketInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/SocketInputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
