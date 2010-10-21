namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.HostNameResolver_))]
	public interface HostNameResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.InetAddress resolve(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.HostNameResolver))]
	public sealed partial class HostNameResolver_ : java.lang.Object, HostNameResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HostNameResolver_()
		{
			InitJNI();
		}
		internal HostNameResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolve32170;
		 global::java.net.InetAddress org.apache.http.conn.scheme.HostNameResolver.resolve(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.HostNameResolver_._resolve32170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.HostNameResolver_.staticClass, global::org.apache.http.conn.scheme.HostNameResolver_._resolve32170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.HostNameResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/HostNameResolver"));
			global::org.apache.http.conn.scheme.HostNameResolver_._resolve32170 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.HostNameResolver_.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/InetAddress;");
		}
	}
}
