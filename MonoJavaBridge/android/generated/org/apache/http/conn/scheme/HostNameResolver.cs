namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.HostNameResolver_))]
	public partial interface HostNameResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.InetAddress resolve(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.HostNameResolver))]
	internal sealed partial class HostNameResolver_ : java.lang.Object, HostNameResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HostNameResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.net.InetAddress org.apache.http.conn.scheme.HostNameResolver.resolve(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.HostNameResolver_.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/InetAddress;", ref global::org.apache.http.conn.scheme.HostNameResolver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.InetAddress;
		}
		static HostNameResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.HostNameResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/HostNameResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
