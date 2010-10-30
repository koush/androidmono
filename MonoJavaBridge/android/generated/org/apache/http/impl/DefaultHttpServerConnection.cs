namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpServerConnection : org.apache.http.impl.SocketHttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32647;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpServerConnection._toString32647.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpServerConnection._toString32647 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._toString32647) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _bind32648;
		public virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpServerConnection._bind32648.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpServerConnection._bind32648 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._bind32648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpServerConnection32649;
		public DefaultHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpServerConnection._DefaultHttpServerConnection32649.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpServerConnection._DefaultHttpServerConnection32649 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._DefaultHttpServerConnection32649);
			Init(@__env, handle);
		}
		static DefaultHttpServerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpServerConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
