namespace org.apache.http.conn.scheme
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HostNameResolver 
	{
		global::java.net.InetAddress resolve(java.lang.String arg0);
	}

	public partial class HostNameResolver_
	{
		public static global::java.lang.Class _class
		{
			get { return __HostNameResolver.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HostNameResolver : java.lang.Object, HostNameResolver
	{
		internal static global::java.lang.Class staticClass;
		static __HostNameResolver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.scheme.__HostNameResolver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.scheme.__HostNameResolver(@__env);
			}
		}
		internal __HostNameResolver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolve14480;
		 global::java.net.InetAddress org.apache.http.conn.scheme.HostNameResolver.resolve(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__HostNameResolver._resolve14480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__HostNameResolver.staticClass, global::org.apache.http.conn.scheme.__HostNameResolver._resolve14480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.scheme.__HostNameResolver.staticClass = @__class;
			global::org.apache.http.conn.scheme.__HostNameResolver._resolve14480 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__HostNameResolver.staticClass, "org.apache.http.conn.scheme.HostNameResolver.resolve", "(Ljava/lang/String;)Ljava/net/InetAddress;");
		}
	}
}
