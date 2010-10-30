namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpClientConnection : org.apache.http.impl.SocketHttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32636;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.DefaultHttpClientConnection._toString32636) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _bind32637;
		public virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.DefaultHttpClientConnection._bind32637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClientConnection32638;
		public DefaultHttpClientConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpClientConnection._DefaultHttpClientConnection32638.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpClientConnection._DefaultHttpClientConnection32638 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpClientConnection.staticClass, global::org.apache.http.impl.DefaultHttpClientConnection._DefaultHttpClientConnection32638);
			Init(@__env, handle);
		}
		static DefaultHttpClientConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpClientConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
