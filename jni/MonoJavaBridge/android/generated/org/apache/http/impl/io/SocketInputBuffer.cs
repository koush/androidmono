namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketInputBuffer : org.apache.http.impl.io.AbstractSessionInputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketInputBuffer()
		{
			InitJNI();
		}
		protected SocketInputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDataAvailable33463;
		public override bool isDataAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.SocketInputBuffer._isDataAvailable33463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.io.SocketInputBuffer.staticClass, global::org.apache.http.impl.io.SocketInputBuffer._isDataAvailable33463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SocketInputBuffer33464;
		public SocketInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.SocketInputBuffer.staticClass, global::org.apache.http.impl.io.SocketInputBuffer._SocketInputBuffer33464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.SocketInputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/SocketInputBuffer"));
			global::org.apache.http.impl.io.SocketInputBuffer._isDataAvailable33463 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.SocketInputBuffer.staticClass, "isDataAvailable", "(I)Z");
			global::org.apache.http.impl.io.SocketInputBuffer._SocketInputBuffer33464 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.SocketInputBuffer.staticClass, "<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V");
		}
	}
}
